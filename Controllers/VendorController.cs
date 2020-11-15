using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreModel.Model;
using ERPMEDICAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ERPMEDICAL.Controllers
{
    public class VendorController : Controller
    {
        private ResponseStatus response_status;
        private ErpMedical _Context;
        public VendorController(ErpMedical Context)
        {
            response_status = new ResponseStatus();
            _Context = Context;
        }
  
        // GET: VendorController/Details/5
        public ActionResult Details(int id)
        {
            //find data from vendor table
            var vendor = _Context.Vendor.Where(m => m.Id == id).FirstOrDefault();
            return View(vendor);
        }

        // POST: VendorController/Create
        [HttpPost]
        public JsonResult Create(Vendor vendor)
        {
            try
            {
                //Add base table
                Base basetable = new Base();
                basetable.CreatedBy = "Admin";
                basetable.CreatedDate = DateTime.Now;
                basetable.UpdatedBy = "";
                //basetable.UpdatedDate = DateTime.Now;
                _Context.Base.Add(basetable);
                //Add vendor table
                vendor.Baseid = basetable.Id;
                _Context.Vendor.Add(vendor);
                //save changes trigger for saving
                _Context.SaveChanges();
                response_status.id = vendor.Id;
                response_status.status = true;
                response_status.successMessage = "data inserted successfull!!";
                return Json(response_status);
            }
            catch (Exception err)
            {
                response_status.id = vendor.Id;
                response_status.status = false;
                response_status.errorMessage = "data inserted not successfull!!";
                return Json(response_status);
            }
           
        }


        // POST: VendorController/Edit/5
        [HttpPut]
        public ActionResult Edit(int id, Vendor vendor)
        {
            try
            {
                //Add base table
                Base basetable = new Base();
                basetable.CreatedBy = "";
                //basetable.CreatedDate = DateTime.Now;
                basetable.UpdatedBy = "Admin";
                basetable.UpdatedDate = DateTime.Now;
                _Context.Base.Add(basetable);
                //find entry against id of vendor
                var vendordetail = _Context.Vendor.FirstOrDefault(O => O.Id == id);
                //Add vendor table UPDATE
                vendor.Baseid = basetable.Id;
                _Context.Vendor.Add(vendordetail);
                //save changes trigger for saving
                _Context.SaveChanges();
                response_status.id = vendor.Id;
                response_status.status = true;
                response_status.successMessage = "data upadted successfull!!";
                return Json(response_status);
            }
            catch (Exception err)
            {
                response_status.id = vendor.Id;
                response_status.status = false;
                response_status.errorMessage = "data updated not successfull!!";
                return Json(response_status);
            }
        }

        // POST: VendorController/Delete/5
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            try
            {
                //first find the objet from vendor
                var vendordata = _Context.Vendor.Where(o => o.Id == id).SingleOrDefault(); 
                response_status.id = vendordata.Id;
                //delete the object by id 
                _Context.Vendor.Remove(vendordata);
                _Context.SaveChanges();
                response_status.status = true;
                response_status.successMessage = "data deleted successfull!!";
                return Json(response_status);
            }
            catch (Exception Err)
            {
                response_status.id = id;
                response_status.status = false;
                response_status.errorMessage = "data deleted not successfull!!";
                return Json(response_status);
            }
        }
    }
}

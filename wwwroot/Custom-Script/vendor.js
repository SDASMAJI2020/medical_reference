/// <reference path="../js/vue/vue.min.js" />
/// <reference path="../js/axios.min.js" />


window.onload = function () {
    const PageLoad = function (thisObj) {
        let vm = thisObj;
        $.ajax({ url: "/Vendor", method: "GET" })
            .done(function (data) {
                //console.log("vendor data", data);
                vm._data.vendors = [...data];
            })
    }
    const clearControl = function () {
        $("#txtVendorName").val('');
        $("#txtVendorEmail").val('');
        $("#txtMobileNo").val('');
        $("#txtAge").val('');
        $("#txtperAddress").val('');
        $("#txtcurrentAddress").val('');
        $("#txtPanCard").val('');
        $("#txtAdhaarCard").val('');
        $("#txtMobileNo").val('');
        $("#txtgstNo").val('');
        $("#txtDlNo").val('');
        $("#txtStation").val('');
        $("#txtVehicalNo").val('');
        $("#txtMedicalNumber").val('');
    }

    const vm = new Vue({
        el: "#app-container",
        data: {
            vendors:[],
            vendor: {
                id: "",
                companyId: "",
                name: "",
                email: "",
                mobileNo: "",
                age: "",
                perAddress: "",
                currentAddress: "",
                panCard: "",
                adhaarCard: "",
                gstNo: "",
                dlNo: "",
                station: "",
                vehicalNo: "",
                medicalCenter: "",
                gstnCN:"" 
            }
        },
        mounted() {
            PageLoad(this);
            //console.log("cosole hit...", vm._data);
            //axios.get("/Vendor/All").then(response => {
            //    console.log("Response data", response);
            //})
        },

        methods: {
            handleChange: function (Event) {
                const { name, value } = Event.target;
               // console.log("name value", name, value);
                switch (name) {
                    case "name":
                        this.vendor.name = value;
                        break;
                    case "email":
                        this.vendor.email = value;
                        break;
                    case "mobileNo":
                        this.vendor.mobileNo = value;
                        break;
                    case "age":
                        this.vendor.age = value;
                        break;
                    case "perAddress":
                        this.vendor.perAddress = value;
                        break;
                    case "currentAddress":
                        this.vendor.currentAddress = value;
                        break;
                    case "panCard":
                        this.vendor.panCard = value;
                        break;
                    case "adhaarCard":
                        this.vendor.adhaarCard = value;
                        break;
                    case "gstNo":
                        this.vendor.gstNo = value;
                        break;
                    case "dlNo":
                        this.vendor.dlNo = value;
                        break;
                    case "station":
                        this.vendor.station = value;
                        break;
                    case "vehicalNo":
                        this.vendor.vehicalNo = value;
                        break;
                    case "medicalCenter":
                        this.vendor.medicalCenter = value;
                        break;
                    case "gstnCN":
                        this.vendor.gstnCN = value;
                        break;
                    default:
                        break;
                }
               
            },
            onSubmit: function () {
                var vm = this;
                
                var newVendor = {
                    Name: vm.vendor.name,
                    Email: vm.vendor.email,
                    MobileNo: vm.vendor.mobileNo,
                    Age: vm.vendor.age,
                    PerAddress: vm.vendor.perAddress,
                    CurrentAddress: vm.vendor.currentAddress,
                    PanCard: vm.vendor.panCard,
                    AdhaarCard: vm.vendor.adhaarCard,
                    GstNo: vm.vendor.gstNo,
                    DlNo: vm.vendor.dlNo,
                    Station: vm.vendor.station,
                    VehicalNo: vm.vendor.vehicalNo,
                    MedicalCenter: vm.vendor.medicalCenter,
                    GstnCn: vm.vendor.gstnCN
                }
                console.log("vendor data", newVendor);
                debugger;
                
                $.ajax({ url: "/Vendor", data: newVendor, method: "POST" })
                    .done(function (data) {
                       // vm.bugs.splice(0, 0, newBug);
                        //toastr.success("New bug added.");
                        //new PNotify({
                        //    title: 'Regular Notice',
                        //    text: data.successMessage,
                        //    type: 'success'
                        //});
                        //  PageLoad(this);
                        $.ajax({ url: "/Vendor", method: "GET" })
                            .done(function (data) {
                                //console.log("vendor data", data);
                                vm.vendors = [...data];
                            }) 
                        //clear control
                        clearControl();
                        //POPUP CLOSE
                        $('#vendorModal').modal('hide');
                    }).fail(function () {
                       // toastr.error("Can not add new bug!");
                    }).always(function () {
                        //vm.clearData();
                    });
            }
        }

    })
}
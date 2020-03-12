//using System.Linq;
//using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public partial class HomeController : Infrastracture.BaseController
    {
        public HomeController() : base()
        {

        }
        [System.Web.Mvc.HttpGet]
        public virtual System.Web.Mvc.ViewResult Index()
        {
            return View();
        }

        public virtual System.Web.Mvc.ViewResult Learn01()
        {
            return View();
        }

        public virtual System.Web.Mvc.ViewResult Learn02()
        {
            return View();
        }

        public virtual System.Web.Mvc.ViewResult Learn03()
        {
            return View();
        }

        public virtual System.Web.Mvc.ViewResult Learn04()
        {
            return View();
        }
        public virtual System.Web.Mvc.ViewResult Learn05()
        {
            return View();
        }

        public virtual System.Web.Mvc.ViewResult Learn06()
        {
            return View();
        }

        public virtual System.Web.Mvc.ViewResult Learn07()
        {
            return View();
        }

        public virtual System.Web.Mvc.ViewResult Learn08()
        {
            return View();
        }

        public virtual System.Web.Mvc.ViewResult Learn09()
        {
            return View();
        }

        public virtual System.Web.Mvc.ViewResult Learn10()
        {
            return View();
        }

        public virtual System.Web.Mvc.ViewResult Learn11()
        {
            return View();
        }

        public virtual System.Web.Mvc.ViewResult Learn12()
        {
            return View();
        }

        public virtual System.Web.Mvc.ViewResult Learn13()
        {
            return View();
        }

        public virtual System.Web.Mvc.ViewResult Learn14()
        {
            return View();
        }

        public virtual System.Web.Mvc.ViewResult Learn15()
        {
            return View();
        }

        public virtual System.Web.Mvc.ViewResult Learn16()
        {
            return View();
        }

        public virtual System.Web.Mvc.ViewResult Learn17()
        {
            return View();
        }

        public virtual System.Web.Mvc.ViewResult Learn18()
        {
            return View();
        }

        public virtual System.Web.Mvc.ViewResult Learn19()
        {
            return View();
        }

        public virtual System.Web.Mvc.ViewResult Learn20()
        {
            return View();
        }

        public virtual System.Web.Mvc.ViewResult Learn21()
        {
            return View();
        }

        public virtual System.Web.Mvc.ViewResult Learn22()
        {
            return View();
        }

        public virtual System.Web.Mvc.ViewResult Learn23()
        {
            return View();
        }

        public virtual System.Web.Mvc.ViewResult Learn24()
        {
            return View();
        }


        //*******************************practicing conecting to Backend from Frontend by axios.js*********************
        #region
        public virtual System.Web.Mvc.ViewResult Learn25()
        {
            return View();
        }

        [System.Web.Mvc.HttpGet]
        public virtual void doSomeThing1()
        {

        }

        [System.Web.Mvc.HttpGet]
        public virtual System.Web.Mvc.JsonResult doSomeThing2()
        {
            return null;
        }

        [System.Web.Mvc.HttpPost]
        public virtual System.Web.Mvc.JsonResult doSomeThing3()
        {
            return null;
        }

        
        public virtual System.Web.Mvc.JsonResult doSomeThing4()
        {
            throw new System.Exception("Some Error Message");
        }
        //Error 500  => server side error
        //*******************************practicing conecting to Backend from Frontend with return Value by axios.js*********************
        [System.Web.Mvc.HttpGet]
        public virtual System.Web.Mvc.ViewResult Learn26()
        {
            return View();
        }

        [System.Web.Mvc.HttpGet]
        public virtual System.Web.Mvc.JsonResult showMessage1()
        {
            System.Threading.Thread.Sleep(millisecondsTimeout: 5000);//ایجاد لختی مصنوعی
            string dataBackEnd = "Data From Back End";
            return Json(data: dataBackEnd, behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet);
        }

        [System.Web.Mvc.HttpGet]
        public virtual System.Web.Mvc.JsonResult showMessage2()
        {
            System.Threading.Thread.Sleep(millisecondsTimeout: 5000);//ایجاد لختی مصنوعی

            ViewModels.DataViewModel viewModel =
                new ViewModels.DataViewModel
                {
                    BackEndData = "Data From Back End",
                };

            return Json(data: viewModel, behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet);
        }

        [System.Web.Mvc.HttpGet]
        public virtual System.Web.Mvc.JsonResult showMessage3()
        {
            System.Threading.Thread.Sleep(millisecondsTimeout: 5000);//ایجاد لختی مصنوعی

            var data =
               new {BackEndData = "Data From Back End",};
            return Json(data: data, behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// use PostMan
        /// </summary>
        /// <returns></returns>
        [System.Web.Mvc.HttpPost]
        public virtual System.Web.Mvc.JsonResult showMessage4()
        {
            System.Threading.Thread.Sleep(millisecondsTimeout: 5000);//ایجاد لختی مصنوعی

            var data =
               new { BackEndData = "Data From Back End", };
            return Json(data: data, behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet);
        }
        //*******************************practicing conecting to Backend from Frontend with Input Value by axios.js*********************
        [System.Web.Mvc.HttpGet]
        public virtual System.Web.Mvc.ViewResult Learn27()
        {
            return View();
        }

        //To get data from view
        //1)creating a class in viewmodel to hold all inputs from view(in controler)
        //2)creating a class in view (in javascript) with the same property in viewmodel class properties in backend(in view)
        //3)initilizing url in view(get and post)

        [System.Web.Mvc.HttpGet]
        public virtual System.Web.Mvc.JsonResult ShowInformationByGet(ViewModels.PersonViewModel personViewModel)
        {
            System.Threading.Thread.Sleep(millisecondsTimeout: 5000);//ایجاد لختی مصنوعی

            var data =
               new { BackEndData = $"Get Resolt From Back-End: My name is {personViewModel.FirstName} {personViewModel.LastName}", };
            return Json(data: data, behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet);
        }

        [System.Web.Mvc.HttpPost]
        public virtual System.Web.Mvc.JsonResult ShowInformationByPost(ViewModels.PersonViewModel personViewModel)
        {
            System.Threading.Thread.Sleep(millisecondsTimeout: 5000);//ایجاد لختی مصنوعی

            var data =
               new { BackEndData = $"Post Resolt From Back-End: My name is {personViewModel.FirstName} {personViewModel.LastName}", };
            return Json(data: data, behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet);
        }
        //*****************************Creating Loading in our pages********************************************
        [System.Web.Mvc.HttpGet]
        public virtual System.Web.Mvc.ViewResult Learn28()
        {
            return View();
        }

        [System.Web.Mvc.HttpGet]
        public virtual System.Web.Mvc.ViewResult Learn29()
        {
            return View();
        }

        [System.Web.Mvc.HttpPost]
        public virtual System.Web.Mvc.JsonResult ShowInformation(ViewModels.PersonViewModel personViewModel)
        {
            System.Threading.Thread.Sleep(millisecondsTimeout: 5000);//ایجاد لختی مصنوعی

            var data =
               new { BackEndData = $"Post Resolt From Back-End: My name is {personViewModel.FirstName} {personViewModel.LastName}", };
            return Json(data: data, behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet);
        }
        #endregion

    }
}
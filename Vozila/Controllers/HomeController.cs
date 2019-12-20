using System;
using System.Web.Mvc;
using System.Threading.Tasks;
using System.Net;
using Vozila.Common;
using Vozila.Models;
using Vozila.Services;
using Vozila.Services.Common;

namespace Vozila.Controllers
{
    public class HomeController : Controller
    {
        #region Fields

        /// <summary>
        /// Vehicle service field.
        /// </summary>
        private IVehicleService vehicleService;
        private IMakeService makeService;

        #endregion

        #region Constructor

        /// <summary>
        /// Home controller constructor.
        /// </summary>
        public HomeController()
        {
            vehicleService = new VehicleService();
            makeService = new MakeService();
        }

        #endregion

        /// <summary>
        /// Index page.
        /// </summary>
        /// <returns>Index view.</returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Back to home page.
        /// </summary>
        /// <returns>Index view.</returns>
        public ActionResult BackToHomePage()
        {
            return RedirectToAction("Index");
        }

        /// <summary>
        /// New vehicle.
        /// </summary>
        /// <returns>Vehicle model.</returns>
        public async Task<ActionResult> NewVehicle()
        {
            ViewBag.MakerCategories = new SelectList(await makeService.GetMakesAsync(), "Id", "Name");

            return View(new VehicleModelPoco());
        }

        /// <summary>
        /// New vehicle.
        /// </summary>
        /// <param name="vehicle">Vehicle.</param>
        /// <returns>Index view if model state is valid.</returns>
        [HttpPost]
        public async Task<ActionResult> NewVehicle(VehicleModelPoco vehicle)
        {
            if (ModelState.IsValid)
            {
                await vehicleService.InsertVehicleAsync(vehicle);
                return RedirectToAction("Index");
            }

            ViewBag.MakerCategories = new SelectList(await makeService.GetMakesAsync(), "Id", "Name");

            return View();
        }

        /// <summary>
        /// Gets vehicles.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <param name="makerId">Maker id.</param>
        /// <param name="findVehicle">Find vehicle.</param>
        /// <param name="sortField">Sort field.</param>
        /// <param name="sortOrder">Sort order.</param>
        /// <param name="pageNumber">Page number.</param>
        /// <param name="pageSize">Page size.</param>
        /// <param name="sorting">Sorting.</param>
        /// <returns>Vehicles.</returns>
        public async Task<ActionResult> GetVehicles(Guid id, Guid? makeId, string findVehicle, string sortField, string sortOrder, int pageNumber = 1, int pageSize = 12, string sorting = "VehicleMake.Name")
        {
            try
            {
                PagingParameters paging = new PagingParameters(pageNumber, pageSize);
                VehicleFilter filtering = new VehicleFilter(id, findVehicle, makeId);

                ViewBag.SortMaker = sorting == "VehicleMake.Name" ? "VehicleMake.Name desc" : "VehicleMake.Name";

                if (sorting.Contains("desc"))
                {
                    string[] sorts = sorting.Split();
                    sortField = sorts[0];
                    sortOrder = sorts[1];
                }
                else
                {
                    sortField = sorting;
                    sortOrder = "";
                }

                SortingParameters sortingFilter = new SortingParameters(sortField, sortOrder);

                ViewBag.Makers = new SelectList(await makeService.GetMakesAsync(), "Id", "Name");
                ViewBag.CurrentSort = sorting;
                ViewBag.CurrentSearch = findVehicle;
                ViewBag.CurrentMaker = makeId;

                return View(await vehicleService.GetVehiclesAsync(paging, filtering, sortingFilter));
            }
            catch
            {
                return new HttpNotFoundResult("There are no vehicles");
            }

        }

        /// <summary>
        /// More details about the vehicle.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>One vehicle.</returns>
        public async Task<ActionResult> MoreDetails(Guid id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var details = await vehicleService.GetVehicleAsync(id);

            if (details == null)
            {
                return HttpNotFound();
            }

            return View(details);
        }

        /// <summary>
        /// Deletes vehicle.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>Get vehicles page.</returns>
        public async Task<ActionResult> DeleteVehicle(Guid id)
        {
            var vehicle = await vehicleService.GetVehicleAsync(id);

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else if (vehicle == null)
            {
                return HttpNotFound();
            }

            await vehicleService.DeleteVehicleAsync(id);
       
        }
    }
}
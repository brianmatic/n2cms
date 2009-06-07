using N2.Templates.Mvc.Items.Items;
using N2.Templates.Mvc.Models;
using N2.Web;
using N2.Web.Mvc;

namespace N2.Templates.Mvc.Controllers
{
	[Controls(typeof(Tracking))]
	public class TrackingController : ContentController<Tracking>
	{
		public override System.Web.Mvc.ActionResult Index()
		{
			return View(new TrackingModel(CurrentItem, CurrentItem.TrackEditors || !Engine.SecurityManager.IsEditor(User)));
		}
	}
}
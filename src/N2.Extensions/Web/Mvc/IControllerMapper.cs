using System;

namespace N2.Web.Mvc
{
	public interface IControllerMapper
	{
		string GetControllerName(Type type);
	}
}
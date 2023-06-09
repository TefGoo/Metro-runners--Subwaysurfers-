
namespace Beamable.Api.Autogenerated.Calendars
{
	using Beamable.Api.Autogenerated.Models;
	using Beamable.Common;
	using Beamable.Common.Content;
	using IBeamableRequester = Beamable.Common.Api.IBeamableRequester;
	using Method = Beamable.Common.Api.Method;

	public partial interface ICalendarsApi
	{
	}
	public partial class CalendarsApi : ICalendarsApi
	{
		private IBeamableRequester _requester;
		public CalendarsApi(IBeamableRequester requester)
		{
			this._requester = requester;
		}
	}
}

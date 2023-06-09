
namespace Beamable.Api.Autogenerated.EventPlayers
{
	using Beamable.Api.Autogenerated.Models;
	using Beamable.Common;
	using Beamable.Common.Content;
	using IBeamableRequester = Beamable.Common.Api.IBeamableRequester;
	using Method = Beamable.Common.Api.Method;

	public partial interface IEventPlayersApi
	{
	}
	public partial class EventPlayersApi : IEventPlayersApi
	{
		private IBeamableRequester _requester;
		public EventPlayersApi(IBeamableRequester requester)
		{
			this._requester = requester;
		}
	}
}

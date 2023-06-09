
namespace Beamable.Api.Autogenerated.Leaderboards
{
	using Beamable.Api.Autogenerated.Models;
	using Beamable.Common;
	using Beamable.Common.Content;
	using IBeamableRequester = Beamable.Common.Api.IBeamableRequester;
	using Method = Beamable.Common.Api.Method;

	public partial interface ILeaderboardsApi
	{
	}
	public partial class LeaderboardsApi : ILeaderboardsApi
	{
		private IBeamableRequester _requester;
		public LeaderboardsApi(IBeamableRequester requester)
		{
			this._requester = requester;
		}
	}
}

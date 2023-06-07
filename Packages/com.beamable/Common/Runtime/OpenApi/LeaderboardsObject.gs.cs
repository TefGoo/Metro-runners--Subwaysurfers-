
namespace Beamable.Api.Autogenerated.Leaderboards
{
	using Beamable.Api.Autogenerated.Models;
	using Beamable.Common;
	using Beamable.Common.Content;
	using IBeamableRequester = Beamable.Common.Api.IBeamableRequester;
	using Method = Beamable.Common.Api.Method;

	public partial interface ILeaderboardsApi
	{
		/// <param name="objectId">Gamertag of the player.</param>
		/// <returns>A promise containing the <see cref="CommonResponse"/></returns>
		Promise<CommonResponse> ObjectDeleteEntries(string objectId);
		/// <param name="objectId">Gamertag of the player.</param>
		/// <param name="playerId"></param>
		/// <returns>A promise containing the <see cref="LeaderboardMembershipResponse"/></returns>
		Promise<LeaderboardMembershipResponse> ObjectGetMembership(string objectId, long playerId);
		/// <param name="ids"></param>
		/// <param name="objectId">Gamertag of the player.</param>
		/// <param name="includeAuthHeader">By default, every request will include an authorization header so that the request acts on behalf of the current user. When the includeAuthHeader argument is false, the request will not include the authorization header for the current user.</param>
		/// <returns>A promise containing the <see cref="LeaderBoardViewResponse"/></returns>
		Promise<LeaderBoardViewResponse> ObjectGetRanks(string ids, string objectId, [System.Runtime.InteropServices.DefaultParameterValueAttribute(true)][System.Runtime.InteropServices.OptionalAttribute()] bool includeAuthHeader);
		/// <param name="objectId">Gamertag of the player.</param>
		/// <param name="playerId"></param>
		/// <returns>A promise containing the <see cref="LeaderboardPartitionInfo"/></returns>
		Promise<LeaderboardPartitionInfo> ObjectGetPartition(string objectId, long playerId);
		/// <param name="objectId">Gamertag of the player.</param>
		/// <returns>A promise containing the <see cref="LeaderBoardViewResponse"/></returns>
		Promise<LeaderBoardViewResponse> ObjectGetFriends(string objectId);
		/// <param name="objectId">Gamertag of the player.</param>
		/// <param name="gsReq">The <see cref="LeaderboardCreateRequest"/> instance to use for the request</param>
		/// <returns>A promise containing the <see cref="CommonResponse"/></returns>
		Promise<CommonResponse> ObjectPost(string objectId, LeaderboardCreateRequest gsReq);
		/// <param name="objectId">Gamertag of the player.</param>
		/// <returns>A promise containing the <see cref="CommonResponse"/></returns>
		Promise<CommonResponse> ObjectDelete(string objectId);
		/// <param name="objectId">Gamertag of the player.</param>
		/// <param name="poolSize"></param>
		/// <param name="windowSize"></param>
		/// <param name="windows"></param>
		/// <param name="includeAuthHeader">By default, every request will include an authorization header so that the request acts on behalf of the current user. When the includeAuthHeader argument is false, the request will not include the authorization header for the current user.</param>
		/// <returns>A promise containing the <see cref="MatchMakingMatchesPvpResponse"/></returns>
		Promise<MatchMakingMatchesPvpResponse> ObjectGetMatches(string objectId, int poolSize, int windowSize, int windows, [System.Runtime.InteropServices.DefaultParameterValueAttribute(true)][System.Runtime.InteropServices.OptionalAttribute()] bool includeAuthHeader);
		/// <param name="objectId">Gamertag of the player.</param>
		/// <returns>A promise containing the <see cref="LeaderboardAssignmentInfo"/></returns>
		Promise<LeaderboardAssignmentInfo> ObjectGetAssignment(string objectId);
		/// <param name="objectId">Gamertag of the player.</param>
		/// <param name="gsReq">The <see cref="LeaderboardRemoveCacheEntryRequest"/> instance to use for the request</param>
		/// <returns>A promise containing the <see cref="CommonResponse"/></returns>
		Promise<CommonResponse> ObjectDeleteAssignment(string objectId, LeaderboardRemoveCacheEntryRequest gsReq);
		/// <param name="objectId">Gamertag of the player.</param>
		/// <param name="gsReq">The <see cref="LeaderboardAddRequest"/> instance to use for the request</param>
		/// <param name="includeAuthHeader">By default, every request will include an authorization header so that the request acts on behalf of the current user. When the includeAuthHeader argument is false, the request will not include the authorization header for the current user.</param>
		/// <returns>A promise containing the <see cref="CommonResponse"/></returns>
		Promise<CommonResponse> ObjectPutEntry(string objectId, LeaderboardAddRequest gsReq, [System.Runtime.InteropServices.DefaultParameterValueAttribute(true)][System.Runtime.InteropServices.OptionalAttribute()] bool includeAuthHeader);
		/// <param name="objectId">Gamertag of the player.</param>
		/// <param name="gsReq">The <see cref="LeaderboardRemoveEntryRequest"/> instance to use for the request</param>
		/// <returns>A promise containing the <see cref="CommonResponse"/></returns>
		Promise<CommonResponse> ObjectDeleteEntry(string objectId, LeaderboardRemoveEntryRequest gsReq);
		/// <param name="objectId">Gamertag of the player.</param>
		/// <returns>A promise containing the <see cref="CommonResponse"/></returns>
		Promise<CommonResponse> ObjectPutFreeze(string objectId);
		/// <param name="from"></param>
		/// <param name="max"></param>
		/// <param name="objectId">Gamertag of the player.</param>
		/// <returns>A promise containing the <see cref="LeaderboardDetails"/></returns>
		Promise<LeaderboardDetails> ObjectGetDetails(string objectId, [System.Runtime.InteropServices.DefaultParameterValueAttribute(null)][System.Runtime.InteropServices.OptionalAttribute()] Beamable.Common.Content.Optional<int> from, [System.Runtime.InteropServices.DefaultParameterValueAttribute(null)][System.Runtime.InteropServices.OptionalAttribute()] Beamable.Common.Content.Optional<int> max);
		/// <param name="focus"></param>
		/// <param name="friends"></param>
		/// <param name="from"></param>
		/// <param name="guild"></param>
		/// <param name="max"></param>
		/// <param name="objectId">Gamertag of the player.</param>
		/// <param name="outlier"></param>
		/// <param name="includeAuthHeader">By default, every request will include an authorization header so that the request acts on behalf of the current user. When the includeAuthHeader argument is false, the request will not include the authorization header for the current user.</param>
		/// <returns>A promise containing the <see cref="LeaderBoardViewResponse"/></returns>
		Promise<LeaderBoardViewResponse> ObjectGetView(string objectId, [System.Runtime.InteropServices.DefaultParameterValueAttribute(null)][System.Runtime.InteropServices.OptionalAttribute()] Beamable.Common.Content.Optional<long> focus, [System.Runtime.InteropServices.DefaultParameterValueAttribute(null)][System.Runtime.InteropServices.OptionalAttribute()] Beamable.Common.Content.Optional<bool> friends, [System.Runtime.InteropServices.DefaultParameterValueAttribute(null)][System.Runtime.InteropServices.OptionalAttribute()] Beamable.Common.Content.Optional<int> from, [System.Runtime.InteropServices.DefaultParameterValueAttribute(null)][System.Runtime.InteropServices.OptionalAttribute()] Beamable.Common.Content.Optional<bool> guild, [System.Runtime.InteropServices.DefaultParameterValueAttribute(null)][System.Runtime.InteropServices.OptionalAttribute()] Beamable.Common.Content.Optional<int> max, [System.Runtime.InteropServices.DefaultParameterValueAttribute(null)][System.Runtime.InteropServices.OptionalAttribute()] Beamable.Common.Content.Optional<long> outlier, [System.Runtime.InteropServices.DefaultParameterValueAttribute(true)][System.Runtime.InteropServices.OptionalAttribute()] bool includeAuthHeader);
		/// <param name="objectId">Gamertag of the player.</param>
		/// <param name="gsReq">The <see cref="LeaderboardSwapRequest"/> instance to use for the request</param>
		/// <returns>A promise containing the <see cref="CommonResponse"/></returns>
		Promise<CommonResponse> ObjectPutSwap(string objectId, LeaderboardSwapRequest gsReq);
	}
	public partial class LeaderboardsApi : ILeaderboardsApi
	{
		/// <param name="objectId">Gamertag of the player.</param>
		/// <returns>A promise containing the <see cref="CommonResponse"/></returns>
		public virtual Promise<CommonResponse> ObjectDeleteEntries(string objectId)
		{
			string gsUrl = "/object/leaderboards/{objectId}/entries";
			gsUrl = gsUrl.Replace("{objectId}", objectId.ToString());
			// make the request and return the result
			return _requester.Request<CommonResponse>(Method.DELETE, gsUrl, default(object), true, Beamable.Serialization.JsonSerializable.FromJson<CommonResponse>);
		}
		/// <param name="objectId">Gamertag of the player.</param>
		/// <param name="playerId"></param>
		/// <returns>A promise containing the <see cref="LeaderboardMembershipResponse"/></returns>
		public virtual Promise<LeaderboardMembershipResponse> ObjectGetMembership(string objectId, long playerId)
		{
			string gsUrl = "/object/leaderboards/{objectId}/membership";
			gsUrl = gsUrl.Replace("{objectId}", objectId.ToString());
			string gsQuery = "?";
			System.Collections.Generic.List<string> gsQueries = new System.Collections.Generic.List<string>();
			gsQueries.Add(string.Concat("playerId=", playerId.ToString()));
			gsQuery = string.Concat(gsQuery, string.Join("&", gsQueries));
			gsUrl = string.Concat(gsUrl, gsQuery);
			// make the request and return the result
			return _requester.Request<LeaderboardMembershipResponse>(Method.GET, gsUrl, default(object), true, Beamable.Serialization.JsonSerializable.FromJson<LeaderboardMembershipResponse>);
		}
		/// <param name="ids"></param>
		/// <param name="objectId">Gamertag of the player.</param>
		/// <param name="includeAuthHeader">By default, every request will include an authorization header so that the request acts on behalf of the current user. When the includeAuthHeader argument is false, the request will not include the authorization header for the current user.</param>
		/// <returns>A promise containing the <see cref="LeaderBoardViewResponse"/></returns>
		public virtual Promise<LeaderBoardViewResponse> ObjectGetRanks(string ids, string objectId, [System.Runtime.InteropServices.DefaultParameterValueAttribute(true)][System.Runtime.InteropServices.OptionalAttribute()] bool includeAuthHeader)
		{
			string gsUrl = "/object/leaderboards/{objectId}/ranks";
			gsUrl = gsUrl.Replace("{objectId}", objectId.ToString());
			string gsQuery = "?";
			System.Collections.Generic.List<string> gsQueries = new System.Collections.Generic.List<string>();
			gsQueries.Add(string.Concat("ids=", ids.ToString()));
			gsQuery = string.Concat(gsQuery, string.Join("&", gsQueries));
			gsUrl = string.Concat(gsUrl, gsQuery);
			// make the request and return the result
			return _requester.Request<LeaderBoardViewResponse>(Method.GET, gsUrl, default(object), includeAuthHeader, Beamable.Serialization.JsonSerializable.FromJson<LeaderBoardViewResponse>);
		}
		/// <param name="objectId">Gamertag of the player.</param>
		/// <param name="playerId"></param>
		/// <returns>A promise containing the <see cref="LeaderboardPartitionInfo"/></returns>
		public virtual Promise<LeaderboardPartitionInfo> ObjectGetPartition(string objectId, long playerId)
		{
			string gsUrl = "/object/leaderboards/{objectId}/partition";
			gsUrl = gsUrl.Replace("{objectId}", objectId.ToString());
			string gsQuery = "?";
			System.Collections.Generic.List<string> gsQueries = new System.Collections.Generic.List<string>();
			gsQueries.Add(string.Concat("playerId=", playerId.ToString()));
			gsQuery = string.Concat(gsQuery, string.Join("&", gsQueries));
			gsUrl = string.Concat(gsUrl, gsQuery);
			// make the request and return the result
			return _requester.Request<LeaderboardPartitionInfo>(Method.GET, gsUrl, default(object), true, Beamable.Serialization.JsonSerializable.FromJson<LeaderboardPartitionInfo>);
		}
		/// <param name="objectId">Gamertag of the player.</param>
		/// <returns>A promise containing the <see cref="LeaderBoardViewResponse"/></returns>
		public virtual Promise<LeaderBoardViewResponse> ObjectGetFriends(string objectId)
		{
			string gsUrl = "/object/leaderboards/{objectId}/friends";
			gsUrl = gsUrl.Replace("{objectId}", objectId.ToString());
			// make the request and return the result
			return _requester.Request<LeaderBoardViewResponse>(Method.GET, gsUrl, default(object), true, Beamable.Serialization.JsonSerializable.FromJson<LeaderBoardViewResponse>);
		}
		/// <param name="objectId">Gamertag of the player.</param>
		/// <param name="gsReq">The <see cref="LeaderboardCreateRequest"/> instance to use for the request</param>
		/// <returns>A promise containing the <see cref="CommonResponse"/></returns>
		public virtual Promise<CommonResponse> ObjectPost(string objectId, LeaderboardCreateRequest gsReq)
		{
			string gsUrl = "/object/leaderboards/{objectId}/";
			gsUrl = gsUrl.Replace("{objectId}", objectId.ToString());
			// make the request and return the result
			return _requester.Request<CommonResponse>(Method.POST, gsUrl, Beamable.Serialization.JsonSerializable.ToJson(gsReq), true, Beamable.Serialization.JsonSerializable.FromJson<CommonResponse>);
		}
		/// <param name="objectId">Gamertag of the player.</param>
		/// <returns>A promise containing the <see cref="CommonResponse"/></returns>
		public virtual Promise<CommonResponse> ObjectDelete(string objectId)
		{
			string gsUrl = "/object/leaderboards/{objectId}/";
			gsUrl = gsUrl.Replace("{objectId}", objectId.ToString());
			// make the request and return the result
			return _requester.Request<CommonResponse>(Method.DELETE, gsUrl, default(object), true, Beamable.Serialization.JsonSerializable.FromJson<CommonResponse>);
		}
		/// <param name="objectId">Gamertag of the player.</param>
		/// <param name="poolSize"></param>
		/// <param name="windowSize"></param>
		/// <param name="windows"></param>
		/// <param name="includeAuthHeader">By default, every request will include an authorization header so that the request acts on behalf of the current user. When the includeAuthHeader argument is false, the request will not include the authorization header for the current user.</param>
		/// <returns>A promise containing the <see cref="MatchMakingMatchesPvpResponse"/></returns>
		public virtual Promise<MatchMakingMatchesPvpResponse> ObjectGetMatches(string objectId, int poolSize, int windowSize, int windows, [System.Runtime.InteropServices.DefaultParameterValueAttribute(true)][System.Runtime.InteropServices.OptionalAttribute()] bool includeAuthHeader)
		{
			string gsUrl = "/object/leaderboards/{objectId}/matches";
			gsUrl = gsUrl.Replace("{objectId}", objectId.ToString());
			string gsQuery = "?";
			System.Collections.Generic.List<string> gsQueries = new System.Collections.Generic.List<string>();
			gsQueries.Add(string.Concat("poolSize=", poolSize.ToString()));
			gsQueries.Add(string.Concat("windows=", windows.ToString()));
			gsQueries.Add(string.Concat("windowSize=", windowSize.ToString()));
			gsQuery = string.Concat(gsQuery, string.Join("&", gsQueries));
			gsUrl = string.Concat(gsUrl, gsQuery);
			// make the request and return the result
			return _requester.Request<MatchMakingMatchesPvpResponse>(Method.GET, gsUrl, default(object), includeAuthHeader, Beamable.Serialization.JsonSerializable.FromJson<MatchMakingMatchesPvpResponse>);
		}
		/// <param name="objectId">Gamertag of the player.</param>
		/// <returns>A promise containing the <see cref="LeaderboardAssignmentInfo"/></returns>
		public virtual Promise<LeaderboardAssignmentInfo> ObjectGetAssignment(string objectId)
		{
			string gsUrl = "/object/leaderboards/{objectId}/assignment";
			gsUrl = gsUrl.Replace("{objectId}", objectId.ToString());
			// make the request and return the result
			return _requester.Request<LeaderboardAssignmentInfo>(Method.GET, gsUrl, default(object), true, Beamable.Serialization.JsonSerializable.FromJson<LeaderboardAssignmentInfo>);
		}
		/// <param name="objectId">Gamertag of the player.</param>
		/// <param name="gsReq">The <see cref="LeaderboardRemoveCacheEntryRequest"/> instance to use for the request</param>
		/// <returns>A promise containing the <see cref="CommonResponse"/></returns>
		public virtual Promise<CommonResponse> ObjectDeleteAssignment(string objectId, LeaderboardRemoveCacheEntryRequest gsReq)
		{
			string gsUrl = "/object/leaderboards/{objectId}/assignment";
			gsUrl = gsUrl.Replace("{objectId}", objectId.ToString());
			// make the request and return the result
			return _requester.Request<CommonResponse>(Method.DELETE, gsUrl, Beamable.Serialization.JsonSerializable.ToJson(gsReq), true, Beamable.Serialization.JsonSerializable.FromJson<CommonResponse>);
		}
		/// <param name="objectId">Gamertag of the player.</param>
		/// <param name="gsReq">The <see cref="LeaderboardAddRequest"/> instance to use for the request</param>
		/// <param name="includeAuthHeader">By default, every request will include an authorization header so that the request acts on behalf of the current user. When the includeAuthHeader argument is false, the request will not include the authorization header for the current user.</param>
		/// <returns>A promise containing the <see cref="CommonResponse"/></returns>
		public virtual Promise<CommonResponse> ObjectPutEntry(string objectId, LeaderboardAddRequest gsReq, [System.Runtime.InteropServices.DefaultParameterValueAttribute(true)][System.Runtime.InteropServices.OptionalAttribute()] bool includeAuthHeader)
		{
			string gsUrl = "/object/leaderboards/{objectId}/entry";
			gsUrl = gsUrl.Replace("{objectId}", objectId.ToString());
			// make the request and return the result
			return _requester.Request<CommonResponse>(Method.PUT, gsUrl, Beamable.Serialization.JsonSerializable.ToJson(gsReq), includeAuthHeader, Beamable.Serialization.JsonSerializable.FromJson<CommonResponse>);
		}
		/// <param name="objectId">Gamertag of the player.</param>
		/// <param name="gsReq">The <see cref="LeaderboardRemoveEntryRequest"/> instance to use for the request</param>
		/// <returns>A promise containing the <see cref="CommonResponse"/></returns>
		public virtual Promise<CommonResponse> ObjectDeleteEntry(string objectId, LeaderboardRemoveEntryRequest gsReq)
		{
			string gsUrl = "/object/leaderboards/{objectId}/entry";
			gsUrl = gsUrl.Replace("{objectId}", objectId.ToString());
			// make the request and return the result
			return _requester.Request<CommonResponse>(Method.DELETE, gsUrl, Beamable.Serialization.JsonSerializable.ToJson(gsReq), true, Beamable.Serialization.JsonSerializable.FromJson<CommonResponse>);
		}
		/// <param name="objectId">Gamertag of the player.</param>
		/// <returns>A promise containing the <see cref="CommonResponse"/></returns>
		public virtual Promise<CommonResponse> ObjectPutFreeze(string objectId)
		{
			string gsUrl = "/object/leaderboards/{objectId}/freeze";
			gsUrl = gsUrl.Replace("{objectId}", objectId.ToString());
			// make the request and return the result
			return _requester.Request<CommonResponse>(Method.PUT, gsUrl, default(object), true, Beamable.Serialization.JsonSerializable.FromJson<CommonResponse>);
		}
		/// <param name="from"></param>
		/// <param name="max"></param>
		/// <param name="objectId">Gamertag of the player.</param>
		/// <returns>A promise containing the <see cref="LeaderboardDetails"/></returns>
		public virtual Promise<LeaderboardDetails> ObjectGetDetails(string objectId, [System.Runtime.InteropServices.DefaultParameterValueAttribute(null)][System.Runtime.InteropServices.OptionalAttribute()] Beamable.Common.Content.Optional<int> from, [System.Runtime.InteropServices.DefaultParameterValueAttribute(null)][System.Runtime.InteropServices.OptionalAttribute()] Beamable.Common.Content.Optional<int> max)
		{
			string gsUrl = "/object/leaderboards/{objectId}/details";
			gsUrl = gsUrl.Replace("{objectId}", objectId.ToString());
			string gsQuery = "?";
			System.Collections.Generic.List<string> gsQueries = new System.Collections.Generic.List<string>();
			if (((from != default(OptionalInt))
						&& from.HasValue))
			{
				gsQueries.Add(string.Concat("from=", from.Value.ToString()));
			}
			if (((max != default(OptionalInt))
						&& max.HasValue))
			{
				gsQueries.Add(string.Concat("max=", max.Value.ToString()));
			}
			gsQuery = string.Concat(gsQuery, string.Join("&", gsQueries));
			gsUrl = string.Concat(gsUrl, gsQuery);
			// make the request and return the result
			return _requester.Request<LeaderboardDetails>(Method.GET, gsUrl, default(object), true, Beamable.Serialization.JsonSerializable.FromJson<LeaderboardDetails>);
		}
		/// <param name="focus"></param>
		/// <param name="friends"></param>
		/// <param name="from"></param>
		/// <param name="guild"></param>
		/// <param name="max"></param>
		/// <param name="objectId">Gamertag of the player.</param>
		/// <param name="outlier"></param>
		/// <param name="includeAuthHeader">By default, every request will include an authorization header so that the request acts on behalf of the current user. When the includeAuthHeader argument is false, the request will not include the authorization header for the current user.</param>
		/// <returns>A promise containing the <see cref="LeaderBoardViewResponse"/></returns>
		public virtual Promise<LeaderBoardViewResponse> ObjectGetView(string objectId, [System.Runtime.InteropServices.DefaultParameterValueAttribute(null)][System.Runtime.InteropServices.OptionalAttribute()] Beamable.Common.Content.Optional<long> focus, [System.Runtime.InteropServices.DefaultParameterValueAttribute(null)][System.Runtime.InteropServices.OptionalAttribute()] Beamable.Common.Content.Optional<bool> friends, [System.Runtime.InteropServices.DefaultParameterValueAttribute(null)][System.Runtime.InteropServices.OptionalAttribute()] Beamable.Common.Content.Optional<int> from, [System.Runtime.InteropServices.DefaultParameterValueAttribute(null)][System.Runtime.InteropServices.OptionalAttribute()] Beamable.Common.Content.Optional<bool> guild, [System.Runtime.InteropServices.DefaultParameterValueAttribute(null)][System.Runtime.InteropServices.OptionalAttribute()] Beamable.Common.Content.Optional<int> max, [System.Runtime.InteropServices.DefaultParameterValueAttribute(null)][System.Runtime.InteropServices.OptionalAttribute()] Beamable.Common.Content.Optional<long> outlier, [System.Runtime.InteropServices.DefaultParameterValueAttribute(true)][System.Runtime.InteropServices.OptionalAttribute()] bool includeAuthHeader)
		{
			string gsUrl = "/object/leaderboards/{objectId}/view";
			gsUrl = gsUrl.Replace("{objectId}", objectId.ToString());
			string gsQuery = "?";
			System.Collections.Generic.List<string> gsQueries = new System.Collections.Generic.List<string>();
			if (((max != default(OptionalInt))
						&& max.HasValue))
			{
				gsQueries.Add(string.Concat("max=", max.Value.ToString()));
			}
			if (((focus != default(OptionalLong))
						&& focus.HasValue))
			{
				gsQueries.Add(string.Concat("focus=", focus.Value.ToString()));
			}
			if (((friends != default(OptionalBool))
						&& friends.HasValue))
			{
				gsQueries.Add(string.Concat("friends=", friends.Value.ToString()));
			}
			if (((from != default(OptionalInt))
						&& from.HasValue))
			{
				gsQueries.Add(string.Concat("from=", from.Value.ToString()));
			}
			if (((outlier != default(OptionalLong))
						&& outlier.HasValue))
			{
				gsQueries.Add(string.Concat("outlier=", outlier.Value.ToString()));
			}
			if (((guild != default(OptionalBool))
						&& guild.HasValue))
			{
				gsQueries.Add(string.Concat("guild=", guild.Value.ToString()));
			}
			gsQuery = string.Concat(gsQuery, string.Join("&", gsQueries));
			gsUrl = string.Concat(gsUrl, gsQuery);
			// make the request and return the result
			return _requester.Request<LeaderBoardViewResponse>(Method.GET, gsUrl, default(object), includeAuthHeader, Beamable.Serialization.JsonSerializable.FromJson<LeaderBoardViewResponse>);
		}
		/// <param name="objectId">Gamertag of the player.</param>
		/// <param name="gsReq">The <see cref="LeaderboardSwapRequest"/> instance to use for the request</param>
		/// <returns>A promise containing the <see cref="CommonResponse"/></returns>
		public virtual Promise<CommonResponse> ObjectPutSwap(string objectId, LeaderboardSwapRequest gsReq)
		{
			string gsUrl = "/object/leaderboards/{objectId}/swap";
			gsUrl = gsUrl.Replace("{objectId}", objectId.ToString());
			// make the request and return the result
			return _requester.Request<CommonResponse>(Method.PUT, gsUrl, Beamable.Serialization.JsonSerializable.ToJson(gsReq), true, Beamable.Serialization.JsonSerializable.FromJson<CommonResponse>);
		}
	}
}

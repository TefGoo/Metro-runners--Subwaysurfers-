
namespace Beamable.Api.Autogenerated.Accounts
{
	using Beamable.Api.Autogenerated.Models;
	using Beamable.Common;
	using Beamable.Common.Content;
	using IBeamableRequester = Beamable.Common.Api.IBeamableRequester;
	using Method = Beamable.Common.Api.Method;

	public partial interface IAccountsApi
	{
		/// <param name="gsReq">The <see cref="DeleteDevicesRequest"/> instance to use for the request</param>
		/// <returns>A promise containing the <see cref="AccountPlayerView"/></returns>
		Promise<AccountPlayerView> DeleteMeDevice(DeleteDevicesRequest gsReq);
		/// <returns>A promise containing the <see cref="AccountPlayerView"/></returns>
		Promise<AccountPlayerView> GetMe();
		/// <param name="gsReq">The <see cref="AccountUpdate"/> instance to use for the request</param>
		/// <returns>A promise containing the <see cref="AccountPlayerView"/></returns>
		Promise<AccountPlayerView> PutMe(AccountUpdate gsReq);
		/// <param name="gsReq">The <see cref="ThirdPartyAvailableRequest"/> instance to use for the request</param>
		/// <returns>A promise containing the <see cref="AccountPlayerView"/></returns>
		Promise<AccountPlayerView> DeleteMeThirdParty(ThirdPartyAvailableRequest gsReq);
		/// <param name="query"></param>
		/// <param name="includeAuthHeader">By default, every request will include an authorization header so that the request acts on behalf of the current user. When the includeAuthHeader argument is false, the request will not include the authorization header for the current user.</param>
		/// <returns>A promise containing the <see cref="AccountPersonallyIdentifiableInformationResponse"/></returns>
		Promise<AccountPersonallyIdentifiableInformationResponse> GetGetPersonallyIdentifiableInformation(string query, [System.Runtime.InteropServices.DefaultParameterValueAttribute(true)][System.Runtime.InteropServices.OptionalAttribute()] bool includeAuthHeader);
		/// <param name="page"></param>
		/// <param name="pagesize"></param>
		/// <param name="query"></param>
		/// <returns>A promise containing the <see cref="AccountSearchResponse"/></returns>
		Promise<AccountSearchResponse> GetSearch(int page, int pagesize, string query);
		/// <param name="gsReq">The <see cref="EmailUpdateRequest"/> instance to use for the request</param>
		/// <returns>A promise containing the <see cref="EmptyResponse"/></returns>
		Promise<EmptyResponse> PostEmailUpdateInit(EmailUpdateRequest gsReq);
		/// <param name="gsReq">The <see cref="EmailUpdateConfirmation"/> instance to use for the request</param>
		/// <returns>A promise containing the <see cref="EmptyResponse"/></returns>
		Promise<EmptyResponse> PostEmailUpdateConfirm(EmailUpdateConfirmation gsReq);
		/// <param name="thirdParty"></param>
		/// <param name="token"></param>
		/// <param name="includeAuthHeader">By default, every request will include an authorization header so that the request acts on behalf of the current user. When the includeAuthHeader argument is false, the request will not include the authorization header for the current user.</param>
		/// <returns>A promise containing the <see cref="AccountAvailableResponse"/></returns>
		Promise<AccountAvailableResponse> GetAvailableThirdParty(string thirdParty, string token, [System.Runtime.InteropServices.DefaultParameterValueAttribute(true)][System.Runtime.InteropServices.OptionalAttribute()] bool includeAuthHeader);
		/// <param name="gsReq">The <see cref="AddAccountRequest"/> instance to use for the request</param>
		/// <returns>A promise containing the <see cref="AccountPortalView"/></returns>
		Promise<AccountPortalView> PostAdminAdminUser(AddAccountRequest gsReq);
		/// <param name="gsReq">The <see cref="AccountRegistration"/> instance to use for the request</param>
		/// <returns>A promise containing the <see cref="AccountPlayerView"/></returns>
		Promise<AccountPlayerView> PostRegister(AccountRegistration gsReq);
		/// <returns>A promise containing the <see cref="AccountPortalView"/></returns>
		Promise<AccountPortalView> GetAdminMe();
		/// <param name="gsReq">The <see cref="PasswordUpdateRequest"/> instance to use for the request</param>
		/// <param name="includeAuthHeader">By default, every request will include an authorization header so that the request acts on behalf of the current user. When the includeAuthHeader argument is false, the request will not include the authorization header for the current user.</param>
		/// <returns>A promise containing the <see cref="EmptyResponse"/></returns>
		Promise<EmptyResponse> PostPasswordUpdateInit(PasswordUpdateRequest gsReq, [System.Runtime.InteropServices.DefaultParameterValueAttribute(true)][System.Runtime.InteropServices.OptionalAttribute()] bool includeAuthHeader);
		/// <returns>A promise containing the <see cref="GetAdminsResponse"/></returns>
		Promise<GetAdminsResponse> GetAdminAdminUsers();
		/// <param name="query"></param>
		/// <returns>A promise containing the <see cref="Account"/></returns>
		Promise<Account> GetFind(string query);
		/// <param name="deviceId"></param>
		/// <param name="includeAuthHeader">By default, every request will include an authorization header so that the request acts on behalf of the current user. When the includeAuthHeader argument is false, the request will not include the authorization header for the current user.</param>
		/// <returns>A promise containing the <see cref="AccountAvailableResponse"/></returns>
		Promise<AccountAvailableResponse> GetAvailableDeviceId(string deviceId, [System.Runtime.InteropServices.DefaultParameterValueAttribute(true)][System.Runtime.InteropServices.OptionalAttribute()] bool includeAuthHeader);
		/// <param name="email"></param>
		/// <param name="includeAuthHeader">By default, every request will include an authorization header so that the request acts on behalf of the current user. When the includeAuthHeader argument is false, the request will not include the authorization header for the current user.</param>
		/// <returns>A promise containing the <see cref="AccountAvailableResponse"/></returns>
		Promise<AccountAvailableResponse> GetAvailable(string email, [System.Runtime.InteropServices.DefaultParameterValueAttribute(true)][System.Runtime.InteropServices.OptionalAttribute()] bool includeAuthHeader);
		/// <param name="gsReq">The <see cref="PasswordUpdateConfirmation"/> instance to use for the request</param>
		/// <param name="includeAuthHeader">By default, every request will include an authorization header so that the request acts on behalf of the current user. When the includeAuthHeader argument is false, the request will not include the authorization header for the current user.</param>
		/// <returns>A promise containing the <see cref="EmptyResponse"/></returns>
		Promise<EmptyResponse> PostPasswordUpdateConfirm(PasswordUpdateConfirmation gsReq, [System.Runtime.InteropServices.DefaultParameterValueAttribute(true)][System.Runtime.InteropServices.OptionalAttribute()] bool includeAuthHeader);
		/// <param name="gsReq">The <see cref="AttachExternalIdentityApiRequest"/> instance to use for the request</param>
		/// <returns>A promise containing the <see cref="AttachExternalIdentityApiResponse"/></returns>
		Promise<AttachExternalIdentityApiResponse> PostExternal_identity(AttachExternalIdentityApiRequest gsReq);
		/// <param name="gsReq">The <see cref="DeleteExternalIdentityApiRequest"/> instance to use for the request</param>
		/// <returns>A promise containing the <see cref="CommonResponse"/></returns>
		Promise<CommonResponse> DeleteExternal_identity(DeleteExternalIdentityApiRequest gsReq);
	}
	public partial class AccountsApi : IAccountsApi
	{
		/// <param name="gsReq">The <see cref="DeleteDevicesRequest"/> instance to use for the request</param>
		/// <returns>A promise containing the <see cref="AccountPlayerView"/></returns>
		public virtual Promise<AccountPlayerView> DeleteMeDevice(DeleteDevicesRequest gsReq)
		{
			string gsUrl = "/basic/accounts/me/device";
			// make the request and return the result
			return _requester.Request<AccountPlayerView>(Method.DELETE, gsUrl, Beamable.Serialization.JsonSerializable.ToJson(gsReq), true, Beamable.Serialization.JsonSerializable.FromJson<AccountPlayerView>);
		}
		/// <returns>A promise containing the <see cref="AccountPlayerView"/></returns>
		public virtual Promise<AccountPlayerView> GetMe()
		{
			string gsUrl = "/basic/accounts/me";
			// make the request and return the result
			return _requester.Request<AccountPlayerView>(Method.GET, gsUrl, default(object), true, Beamable.Serialization.JsonSerializable.FromJson<AccountPlayerView>);
		}
		/// <param name="gsReq">The <see cref="AccountUpdate"/> instance to use for the request</param>
		/// <returns>A promise containing the <see cref="AccountPlayerView"/></returns>
		public virtual Promise<AccountPlayerView> PutMe(AccountUpdate gsReq)
		{
			string gsUrl = "/basic/accounts/me";
			// make the request and return the result
			return _requester.Request<AccountPlayerView>(Method.PUT, gsUrl, Beamable.Serialization.JsonSerializable.ToJson(gsReq), true, Beamable.Serialization.JsonSerializable.FromJson<AccountPlayerView>);
		}
		/// <param name="gsReq">The <see cref="ThirdPartyAvailableRequest"/> instance to use for the request</param>
		/// <returns>A promise containing the <see cref="AccountPlayerView"/></returns>
		public virtual Promise<AccountPlayerView> DeleteMeThirdParty(ThirdPartyAvailableRequest gsReq)
		{
			string gsUrl = "/basic/accounts/me/third-party";
			// make the request and return the result
			return _requester.Request<AccountPlayerView>(Method.DELETE, gsUrl, Beamable.Serialization.JsonSerializable.ToJson(gsReq), true, Beamable.Serialization.JsonSerializable.FromJson<AccountPlayerView>);
		}
		/// <param name="query"></param>
		/// <param name="includeAuthHeader">By default, every request will include an authorization header so that the request acts on behalf of the current user. When the includeAuthHeader argument is false, the request will not include the authorization header for the current user.</param>
		/// <returns>A promise containing the <see cref="AccountPersonallyIdentifiableInformationResponse"/></returns>
		public virtual Promise<AccountPersonallyIdentifiableInformationResponse> GetGetPersonallyIdentifiableInformation(string query, [System.Runtime.InteropServices.DefaultParameterValueAttribute(true)][System.Runtime.InteropServices.OptionalAttribute()] bool includeAuthHeader)
		{
			string gsUrl = "/basic/accounts/get-personally-identifiable-information";
			string gsQuery = "?";
			System.Collections.Generic.List<string> gsQueries = new System.Collections.Generic.List<string>();
			gsQueries.Add(string.Concat("query=", query.ToString()));
			gsQuery = string.Concat(gsQuery, string.Join("&", gsQueries));
			gsUrl = string.Concat(gsUrl, gsQuery);
			// make the request and return the result
			return _requester.Request<AccountPersonallyIdentifiableInformationResponse>(Method.GET, gsUrl, default(object), includeAuthHeader, Beamable.Serialization.JsonSerializable.FromJson<AccountPersonallyIdentifiableInformationResponse>);
		}
		/// <param name="page"></param>
		/// <param name="pagesize"></param>
		/// <param name="query"></param>
		/// <returns>A promise containing the <see cref="AccountSearchResponse"/></returns>
		public virtual Promise<AccountSearchResponse> GetSearch(int page, int pagesize, string query)
		{
			string gsUrl = "/basic/accounts/search";
			string gsQuery = "?";
			System.Collections.Generic.List<string> gsQueries = new System.Collections.Generic.List<string>();
			gsQueries.Add(string.Concat("query=", query.ToString()));
			gsQueries.Add(string.Concat("page=", page.ToString()));
			gsQueries.Add(string.Concat("pagesize=", pagesize.ToString()));
			gsQuery = string.Concat(gsQuery, string.Join("&", gsQueries));
			gsUrl = string.Concat(gsUrl, gsQuery);
			// make the request and return the result
			return _requester.Request<AccountSearchResponse>(Method.GET, gsUrl, default(object), true, Beamable.Serialization.JsonSerializable.FromJson<AccountSearchResponse>);
		}
		/// <param name="gsReq">The <see cref="EmailUpdateRequest"/> instance to use for the request</param>
		/// <returns>A promise containing the <see cref="EmptyResponse"/></returns>
		public virtual Promise<EmptyResponse> PostEmailUpdateInit(EmailUpdateRequest gsReq)
		{
			string gsUrl = "/basic/accounts/email-update/init";
			// make the request and return the result
			return _requester.Request<EmptyResponse>(Method.POST, gsUrl, Beamable.Serialization.JsonSerializable.ToJson(gsReq), true, Beamable.Serialization.JsonSerializable.FromJson<EmptyResponse>);
		}
		/// <param name="gsReq">The <see cref="EmailUpdateConfirmation"/> instance to use for the request</param>
		/// <returns>A promise containing the <see cref="EmptyResponse"/></returns>
		public virtual Promise<EmptyResponse> PostEmailUpdateConfirm(EmailUpdateConfirmation gsReq)
		{
			string gsUrl = "/basic/accounts/email-update/confirm";
			// make the request and return the result
			return _requester.Request<EmptyResponse>(Method.POST, gsUrl, Beamable.Serialization.JsonSerializable.ToJson(gsReq), true, Beamable.Serialization.JsonSerializable.FromJson<EmptyResponse>);
		}
		/// <param name="thirdParty"></param>
		/// <param name="token"></param>
		/// <param name="includeAuthHeader">By default, every request will include an authorization header so that the request acts on behalf of the current user. When the includeAuthHeader argument is false, the request will not include the authorization header for the current user.</param>
		/// <returns>A promise containing the <see cref="AccountAvailableResponse"/></returns>
		public virtual Promise<AccountAvailableResponse> GetAvailableThirdParty(string thirdParty, string token, [System.Runtime.InteropServices.DefaultParameterValueAttribute(true)][System.Runtime.InteropServices.OptionalAttribute()] bool includeAuthHeader)
		{
			string gsUrl = "/basic/accounts/available/third-party";
			string gsQuery = "?";
			System.Collections.Generic.List<string> gsQueries = new System.Collections.Generic.List<string>();
			gsQueries.Add(string.Concat("thirdParty=", thirdParty.ToString()));
			gsQueries.Add(string.Concat("token=", token.ToString()));
			gsQuery = string.Concat(gsQuery, string.Join("&", gsQueries));
			gsUrl = string.Concat(gsUrl, gsQuery);
			// make the request and return the result
			return _requester.Request<AccountAvailableResponse>(Method.GET, gsUrl, default(object), includeAuthHeader, Beamable.Serialization.JsonSerializable.FromJson<AccountAvailableResponse>);
		}
		/// <param name="gsReq">The <see cref="AddAccountRequest"/> instance to use for the request</param>
		/// <returns>A promise containing the <see cref="AccountPortalView"/></returns>
		public virtual Promise<AccountPortalView> PostAdminAdminUser(AddAccountRequest gsReq)
		{
			string gsUrl = "/basic/accounts/admin/admin-user";
			// make the request and return the result
			return _requester.Request<AccountPortalView>(Method.POST, gsUrl, Beamable.Serialization.JsonSerializable.ToJson(gsReq), true, Beamable.Serialization.JsonSerializable.FromJson<AccountPortalView>);
		}
		/// <param name="gsReq">The <see cref="AccountRegistration"/> instance to use for the request</param>
		/// <returns>A promise containing the <see cref="AccountPlayerView"/></returns>
		public virtual Promise<AccountPlayerView> PostRegister(AccountRegistration gsReq)
		{
			string gsUrl = "/basic/accounts/register";
			// make the request and return the result
			return _requester.Request<AccountPlayerView>(Method.POST, gsUrl, Beamable.Serialization.JsonSerializable.ToJson(gsReq), true, Beamable.Serialization.JsonSerializable.FromJson<AccountPlayerView>);
		}
		/// <returns>A promise containing the <see cref="AccountPortalView"/></returns>
		public virtual Promise<AccountPortalView> GetAdminMe()
		{
			string gsUrl = "/basic/accounts/admin/me";
			// make the request and return the result
			return _requester.Request<AccountPortalView>(Method.GET, gsUrl, default(object), true, Beamable.Serialization.JsonSerializable.FromJson<AccountPortalView>);
		}
		/// <param name="gsReq">The <see cref="PasswordUpdateRequest"/> instance to use for the request</param>
		/// <param name="includeAuthHeader">By default, every request will include an authorization header so that the request acts on behalf of the current user. When the includeAuthHeader argument is false, the request will not include the authorization header for the current user.</param>
		/// <returns>A promise containing the <see cref="EmptyResponse"/></returns>
		public virtual Promise<EmptyResponse> PostPasswordUpdateInit(PasswordUpdateRequest gsReq, [System.Runtime.InteropServices.DefaultParameterValueAttribute(true)][System.Runtime.InteropServices.OptionalAttribute()] bool includeAuthHeader)
		{
			string gsUrl = "/basic/accounts/password-update/init";
			// make the request and return the result
			return _requester.Request<EmptyResponse>(Method.POST, gsUrl, Beamable.Serialization.JsonSerializable.ToJson(gsReq), includeAuthHeader, Beamable.Serialization.JsonSerializable.FromJson<EmptyResponse>);
		}
		/// <returns>A promise containing the <see cref="GetAdminsResponse"/></returns>
		public virtual Promise<GetAdminsResponse> GetAdminAdminUsers()
		{
			string gsUrl = "/basic/accounts/admin/admin-users";
			// make the request and return the result
			return _requester.Request<GetAdminsResponse>(Method.GET, gsUrl, default(object), true, Beamable.Serialization.JsonSerializable.FromJson<GetAdminsResponse>);
		}
		/// <param name="query"></param>
		/// <returns>A promise containing the <see cref="Account"/></returns>
		public virtual Promise<Account> GetFind(string query)
		{
			string gsUrl = "/basic/accounts/find";
			string gsQuery = "?";
			System.Collections.Generic.List<string> gsQueries = new System.Collections.Generic.List<string>();
			gsQueries.Add(string.Concat("query=", query.ToString()));
			gsQuery = string.Concat(gsQuery, string.Join("&", gsQueries));
			gsUrl = string.Concat(gsUrl, gsQuery);
			// make the request and return the result
			return _requester.Request<Account>(Method.GET, gsUrl, default(object), true, Beamable.Serialization.JsonSerializable.FromJson<Account>);
		}
		/// <param name="deviceId"></param>
		/// <param name="includeAuthHeader">By default, every request will include an authorization header so that the request acts on behalf of the current user. When the includeAuthHeader argument is false, the request will not include the authorization header for the current user.</param>
		/// <returns>A promise containing the <see cref="AccountAvailableResponse"/></returns>
		public virtual Promise<AccountAvailableResponse> GetAvailableDeviceId(string deviceId, [System.Runtime.InteropServices.DefaultParameterValueAttribute(true)][System.Runtime.InteropServices.OptionalAttribute()] bool includeAuthHeader)
		{
			string gsUrl = "/basic/accounts/available/device-id";
			string gsQuery = "?";
			System.Collections.Generic.List<string> gsQueries = new System.Collections.Generic.List<string>();
			gsQueries.Add(string.Concat("deviceId=", deviceId.ToString()));
			gsQuery = string.Concat(gsQuery, string.Join("&", gsQueries));
			gsUrl = string.Concat(gsUrl, gsQuery);
			// make the request and return the result
			return _requester.Request<AccountAvailableResponse>(Method.GET, gsUrl, default(object), includeAuthHeader, Beamable.Serialization.JsonSerializable.FromJson<AccountAvailableResponse>);
		}
		/// <param name="email"></param>
		/// <param name="includeAuthHeader">By default, every request will include an authorization header so that the request acts on behalf of the current user. When the includeAuthHeader argument is false, the request will not include the authorization header for the current user.</param>
		/// <returns>A promise containing the <see cref="AccountAvailableResponse"/></returns>
		public virtual Promise<AccountAvailableResponse> GetAvailable(string email, [System.Runtime.InteropServices.DefaultParameterValueAttribute(true)][System.Runtime.InteropServices.OptionalAttribute()] bool includeAuthHeader)
		{
			string gsUrl = "/basic/accounts/available";
			string gsQuery = "?";
			System.Collections.Generic.List<string> gsQueries = new System.Collections.Generic.List<string>();
			gsQueries.Add(string.Concat("email=", email.ToString()));
			gsQuery = string.Concat(gsQuery, string.Join("&", gsQueries));
			gsUrl = string.Concat(gsUrl, gsQuery);
			// make the request and return the result
			return _requester.Request<AccountAvailableResponse>(Method.GET, gsUrl, default(object), includeAuthHeader, Beamable.Serialization.JsonSerializable.FromJson<AccountAvailableResponse>);
		}
		/// <param name="gsReq">The <see cref="PasswordUpdateConfirmation"/> instance to use for the request</param>
		/// <param name="includeAuthHeader">By default, every request will include an authorization header so that the request acts on behalf of the current user. When the includeAuthHeader argument is false, the request will not include the authorization header for the current user.</param>
		/// <returns>A promise containing the <see cref="EmptyResponse"/></returns>
		public virtual Promise<EmptyResponse> PostPasswordUpdateConfirm(PasswordUpdateConfirmation gsReq, [System.Runtime.InteropServices.DefaultParameterValueAttribute(true)][System.Runtime.InteropServices.OptionalAttribute()] bool includeAuthHeader)
		{
			string gsUrl = "/basic/accounts/password-update/confirm";
			// make the request and return the result
			return _requester.Request<EmptyResponse>(Method.POST, gsUrl, Beamable.Serialization.JsonSerializable.ToJson(gsReq), includeAuthHeader, Beamable.Serialization.JsonSerializable.FromJson<EmptyResponse>);
		}
		/// <param name="gsReq">The <see cref="AttachExternalIdentityApiRequest"/> instance to use for the request</param>
		/// <returns>A promise containing the <see cref="AttachExternalIdentityApiResponse"/></returns>
		public virtual Promise<AttachExternalIdentityApiResponse> PostExternal_identity(AttachExternalIdentityApiRequest gsReq)
		{
			string gsUrl = "/basic/accounts/external_identity";
			// make the request and return the result
			return _requester.Request<AttachExternalIdentityApiResponse>(Method.POST, gsUrl, Beamable.Serialization.JsonSerializable.ToJson(gsReq), true, Beamable.Serialization.JsonSerializable.FromJson<AttachExternalIdentityApiResponse>);
		}
		/// <param name="gsReq">The <see cref="DeleteExternalIdentityApiRequest"/> instance to use for the request</param>
		/// <returns>A promise containing the <see cref="CommonResponse"/></returns>
		public virtual Promise<CommonResponse> DeleteExternal_identity(DeleteExternalIdentityApiRequest gsReq)
		{
			string gsUrl = "/basic/accounts/external_identity";
			// make the request and return the result
			return _requester.Request<CommonResponse>(Method.DELETE, gsUrl, Beamable.Serialization.JsonSerializable.ToJson(gsReq), true, Beamable.Serialization.JsonSerializable.FromJson<CommonResponse>);
		}
	}
}

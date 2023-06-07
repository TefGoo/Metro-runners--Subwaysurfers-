
namespace Beamable.Api.Autogenerated.Push
{
	using Beamable.Api.Autogenerated.Models;
	using Beamable.Common;
	using Beamable.Common.Content;
	using IBeamableRequester = Beamable.Common.Api.IBeamableRequester;
	using Method = Beamable.Common.Api.Method;

	public partial interface IPushApi
	{
		/// <param name="gsReq">The <see cref="RegisterReq"/> instance to use for the request</param>
		/// <returns>A promise containing the <see cref="EmptyRsp"/></returns>
		Promise<EmptyRsp> PostRegister(RegisterReq gsReq);
		/// <param name="gsReq">The <see cref="SendReq"/> instance to use for the request</param>
		/// <returns>A promise containing the <see cref="EmptyRsp"/></returns>
		Promise<EmptyRsp> PostSend(SendReq gsReq);
	}
	public partial class PushApi : IPushApi
	{
		/// <param name="gsReq">The <see cref="RegisterReq"/> instance to use for the request</param>
		/// <returns>A promise containing the <see cref="EmptyRsp"/></returns>
		public virtual Promise<EmptyRsp> PostRegister(RegisterReq gsReq)
		{
			string gsUrl = "/basic/push/register";
			// make the request and return the result
			return _requester.Request<EmptyRsp>(Method.POST, gsUrl, Beamable.Serialization.JsonSerializable.ToJson(gsReq), true, Beamable.Serialization.JsonSerializable.FromJson<EmptyRsp>);
		}
		/// <param name="gsReq">The <see cref="SendReq"/> instance to use for the request</param>
		/// <returns>A promise containing the <see cref="EmptyRsp"/></returns>
		public virtual Promise<EmptyRsp> PostSend(SendReq gsReq)
		{
			string gsUrl = "/basic/push/send";
			// make the request and return the result
			return _requester.Request<EmptyRsp>(Method.POST, gsUrl, Beamable.Serialization.JsonSerializable.ToJson(gsReq), true, Beamable.Serialization.JsonSerializable.FromJson<EmptyRsp>);
		}
	}
}


namespace Beamable.Api.Autogenerated.Payments
{
	using Beamable.Api.Autogenerated.Models;
	using Beamable.Common;
	using Beamable.Common.Content;
	using IBeamableRequester = Beamable.Common.Api.IBeamableRequester;
	using Method = Beamable.Common.Api.Method;

	public partial interface IPaymentsApi
	{
	}
	public partial class PaymentsApi : IPaymentsApi
	{
		private IBeamableRequester _requester;
		public PaymentsApi(IBeamableRequester requester)
		{
			this._requester = requester;
		}
	}
}

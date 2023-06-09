using Beamable.Common.Content;
using System;
using System.Linq;

namespace Beamable.Api.Autogenerated.Models
{


	#region MailObjectPlayerReward --> PlayerReward

	[Obsolete("Use " + nameof(PlayerReward) + " instead.")]
	public partial class MailObjectPlayerReward
	{
		public MapOfString addCurrencyMap = new MapOfString();
		public ItemCreateRequest[] addItemRequests;
		public OptionalNewItemRewardArray addItems = new OptionalNewItemRewardArray();
		public OptionalBool applyVipBonus = new OptionalBool();
		public OptionalWebhookRewardArray callWebhooks = new OptionalWebhookRewardArray();
		public OptionalCurrencyChangeRewardArray changeCurrencies = new OptionalCurrencyChangeRewardArray();
		public OptionalString description = new OptionalString();
		public virtual void Serialize(Beamable.Serialization.JsonSerializable.IStreamSerializer s)
		{
			s.SerializeDictionary<MapOfString, string>("addCurrencyMap", ref addCurrencyMap);
			s.SerializeArray("addItemRequests", ref addItemRequests);
			if ((s.HasKey("addItems")
				 || ((addItems != default(OptionalNewItemRewardArray))
					 && addItems.HasValue)))
			{
				s.SerializeArray("addItems", ref addItems.Value);
				addItems.HasValue = true;
			}
			if ((s.HasKey("applyVipBonus")
				 || ((applyVipBonus != default(OptionalBool))
					 && applyVipBonus.HasValue)))
			{
				s.Serialize("applyVipBonus", ref applyVipBonus.Value);
				applyVipBonus.HasValue = true;
			}
			if ((s.HasKey("callWebhooks")
				 || ((callWebhooks != default(OptionalWebhookRewardArray))
					 && callWebhooks.HasValue)))
			{
				s.SerializeArray("callWebhooks", ref callWebhooks.Value);
				callWebhooks.HasValue = true;
			}
			if ((s.HasKey("changeCurrencies")
				 || ((changeCurrencies != default(OptionalCurrencyChangeRewardArray))
					 && changeCurrencies.HasValue)))
			{
				s.SerializeArray("changeCurrencies", ref changeCurrencies.Value);
				changeCurrencies.HasValue = true;
			}
			if ((s.HasKey("description")
				 || ((description != default(OptionalString))
					 && description.HasValue)))
			{
				s.Serialize("description", ref description.Value);
				description.HasValue = true;
			}
		}
	}

	public partial class PlayerReward
	{
#pragma warning disable CS0618
		public static implicit operator MailObjectPlayerReward(PlayerReward reward) =>
			new MailObjectPlayerReward
			{
				addCurrencyMap = reward.addCurrencyMap,
				addItemRequests = reward.addItemRequests,
				addItems = reward.addItems,
				applyVipBonus = reward.applyVipBonus,
				callWebhooks = reward.callWebhooks,
				changeCurrencies = reward.changeCurrencies,
				description = reward.description
			};
#pragma warning restore CS0618

	}

	#endregion

	#region MailBasicPlayerReward --> PlayerReward

	[Obsolete("Use " + nameof(PlayerReward) + " instead.")]
	public partial class MailBasicPlayerReward
	{
		public MapOfString addCurrencyMap = new MapOfString();
		public ItemCreateRequest[] addItemRequests;
		public OptionalNewItemRewardArray addItems = new OptionalNewItemRewardArray();
		public OptionalBool applyVipBonus = new OptionalBool();
		public OptionalWebhookRewardArray callWebhooks = new OptionalWebhookRewardArray();
		public OptionalCurrencyChangeRewardArray changeCurrencies = new OptionalCurrencyChangeRewardArray();
		public OptionalString description = new OptionalString();
		public virtual void Serialize(Beamable.Serialization.JsonSerializable.IStreamSerializer s)
		{
			s.SerializeDictionary<MapOfString, string>("addCurrencyMap", ref addCurrencyMap);
			s.SerializeArray("addItemRequests", ref addItemRequests);
			if ((s.HasKey("addItems")
				 || ((addItems != default(OptionalNewItemRewardArray))
					 && addItems.HasValue)))
			{
				s.SerializeArray("addItems", ref addItems.Value);
				addItems.HasValue = true;
			}
			if ((s.HasKey("applyVipBonus")
				 || ((applyVipBonus != default(OptionalBool))
					 && applyVipBonus.HasValue)))
			{
				s.Serialize("applyVipBonus", ref applyVipBonus.Value);
				applyVipBonus.HasValue = true;
			}
			if ((s.HasKey("callWebhooks")
				 || ((callWebhooks != default(OptionalWebhookRewardArray))
					 && callWebhooks.HasValue)))
			{
				s.SerializeArray("callWebhooks", ref callWebhooks.Value);
				callWebhooks.HasValue = true;
			}
			if ((s.HasKey("changeCurrencies")
				 || ((changeCurrencies != default(OptionalCurrencyChangeRewardArray))
					 && changeCurrencies.HasValue)))
			{
				s.SerializeArray("changeCurrencies", ref changeCurrencies.Value);
				changeCurrencies.HasValue = true;
			}
			if ((s.HasKey("description")
				 || ((description != default(OptionalString))
					 && description.HasValue)))
			{
				s.Serialize("description", ref description.Value);
				description.HasValue = true;
			}
		}
	}

	public partial class PlayerReward
	{
#pragma warning disable CS0618
		public static implicit operator MailBasicPlayerReward(PlayerReward reward) =>
			new MailBasicPlayerReward
			{
				addCurrencyMap = reward.addCurrencyMap,
				addItemRequests = reward.addItemRequests,
				addItems = reward.addItems,
				applyVipBonus = reward.applyVipBonus,
				callWebhooks = reward.callWebhooks,
				changeCurrencies = reward.changeCurrencies,
				description = reward.description
			};
#pragma warning restore CS0618

	}

	#endregion

	#region AnnouncementsObjectPlayerReward --> PlayerReward

	[Obsolete("Use " + nameof(PlayerReward) + " instead.")]
	public partial class AnnouncementsObjectPlayerReward
	{
		public MapOfString addCurrencyMap = new MapOfString();
		public ItemCreateRequest[] addItemRequests;
		public OptionalNewItemRewardArray addItems = new OptionalNewItemRewardArray();
		public OptionalBool applyVipBonus = new OptionalBool();
		public OptionalWebhookRewardArray callWebhooks = new OptionalWebhookRewardArray();
		public OptionalCurrencyChangeRewardArray changeCurrencies = new OptionalCurrencyChangeRewardArray();
		public OptionalString description = new OptionalString();
		public virtual void Serialize(Beamable.Serialization.JsonSerializable.IStreamSerializer s)
		{
			s.SerializeDictionary<MapOfString, string>("addCurrencyMap", ref addCurrencyMap);
			s.SerializeArray("addItemRequests", ref addItemRequests);
			if ((s.HasKey("addItems")
				 || ((addItems != default(OptionalNewItemRewardArray))
					 && addItems.HasValue)))
			{
				s.SerializeArray("addItems", ref addItems.Value);
				addItems.HasValue = true;
			}
			if ((s.HasKey("applyVipBonus")
				 || ((applyVipBonus != default(OptionalBool))
					 && applyVipBonus.HasValue)))
			{
				s.Serialize("applyVipBonus", ref applyVipBonus.Value);
				applyVipBonus.HasValue = true;
			}
			if ((s.HasKey("callWebhooks")
				 || ((callWebhooks != default(OptionalWebhookRewardArray))
					 && callWebhooks.HasValue)))
			{
				s.SerializeArray("callWebhooks", ref callWebhooks.Value);
				callWebhooks.HasValue = true;
			}
			if ((s.HasKey("changeCurrencies")
				 || ((changeCurrencies != default(OptionalCurrencyChangeRewardArray))
					 && changeCurrencies.HasValue)))
			{
				s.SerializeArray("changeCurrencies", ref changeCurrencies.Value);
				changeCurrencies.HasValue = true;
			}
			if ((s.HasKey("description")
				 || ((description != default(OptionalString))
					 && description.HasValue)))
			{
				s.Serialize("description", ref description.Value);
				description.HasValue = true;
			}
		}
	}

	public partial class PlayerReward
	{
#pragma warning disable CS0618
		public static implicit operator AnnouncementsObjectPlayerReward(PlayerReward reward) =>
			new AnnouncementsObjectPlayerReward
			{
				addCurrencyMap = reward.addCurrencyMap,
				addItemRequests = reward.addItemRequests,
				addItems = reward.addItems,
				applyVipBonus = reward.applyVipBonus,
				callWebhooks = reward.callWebhooks,
				changeCurrencies = reward.changeCurrencies,
				description = reward.description
			};
#pragma warning restore CS0618

	}

	#endregion

	#region AnnouncementsBasicPlayerReward --> PlayerReward

	[Obsolete("Use " + nameof(PlayerReward) + " instead.")]
	public partial class AnnouncementsBasicPlayerReward
	{
		public MapOfString addCurrencyMap = new MapOfString();
		public ItemCreateRequest[] addItemRequests;
		public OptionalNewItemRewardArray addItems = new OptionalNewItemRewardArray();
		public OptionalBool applyVipBonus = new OptionalBool();
		public OptionalWebhookRewardArray callWebhooks = new OptionalWebhookRewardArray();
		public OptionalCurrencyChangeRewardArray changeCurrencies = new OptionalCurrencyChangeRewardArray();
		public OptionalString description = new OptionalString();
		public virtual void Serialize(Beamable.Serialization.JsonSerializable.IStreamSerializer s)
		{
			s.SerializeDictionary<MapOfString, string>("addCurrencyMap", ref addCurrencyMap);
			s.SerializeArray("addItemRequests", ref addItemRequests);
			if ((s.HasKey("addItems")
				 || ((addItems != default(OptionalNewItemRewardArray))
					 && addItems.HasValue)))
			{
				s.SerializeArray("addItems", ref addItems.Value);
				addItems.HasValue = true;
			}
			if ((s.HasKey("applyVipBonus")
				 || ((applyVipBonus != default(OptionalBool))
					 && applyVipBonus.HasValue)))
			{
				s.Serialize("applyVipBonus", ref applyVipBonus.Value);
				applyVipBonus.HasValue = true;
			}
			if ((s.HasKey("callWebhooks")
				 || ((callWebhooks != default(OptionalWebhookRewardArray))
					 && callWebhooks.HasValue)))
			{
				s.SerializeArray("callWebhooks", ref callWebhooks.Value);
				callWebhooks.HasValue = true;
			}
			if ((s.HasKey("changeCurrencies")
				 || ((changeCurrencies != default(OptionalCurrencyChangeRewardArray))
					 && changeCurrencies.HasValue)))
			{
				s.SerializeArray("changeCurrencies", ref changeCurrencies.Value);
				changeCurrencies.HasValue = true;
			}
			if ((s.HasKey("description")
				 || ((description != default(OptionalString))
					 && description.HasValue)))
			{
				s.Serialize("description", ref description.Value);
				description.HasValue = true;
			}
		}
	}

	public partial class PlayerReward
	{
#pragma warning disable CS0618
		public static implicit operator AnnouncementsBasicPlayerReward(PlayerReward reward) =>
			new AnnouncementsBasicPlayerReward
			{
				addCurrencyMap = reward.addCurrencyMap,
				addItemRequests = reward.addItemRequests,
				addItems = reward.addItems,
				applyVipBonus = reward.applyVipBonus,
				callWebhooks = reward.callWebhooks,
				changeCurrencies = reward.changeCurrencies,
				description = reward.description
			};
#pragma warning restore CS0618

	}

	#endregion

	#region MailBasicBulkSendMailRequest --> BulkSendMailRequest
	[Obsolete("Use " + nameof(BulkSendMailRequest) + " instead.")]
	public partial class MailBasicBulkSendMailRequest
	{
		public MailBasicSendMailRequest[] sendMailRequests;
		public virtual void Serialize(Beamable.Serialization.JsonSerializable.IStreamSerializer s)
		{
			s.SerializeArray("sendMailRequests", ref sendMailRequests);
		}
	}

	public partial class BulkSendMailRequest
	{
#pragma warning disable CS0618
		public static implicit operator MailBasicBulkSendMailRequest(BulkSendMailRequest req) =>
			new MailBasicBulkSendMailRequest
			{
				sendMailRequests = req.sendMailRequests.Select(r =>
				{
					MailBasicSendMailRequest converted = r;
					return converted;
				}).ToArray()
			};
#pragma warning restore CS0618

	}
	#endregion

	#region MailObjectBulkSendMailRequest --> BulkSendMailRequest
	[Obsolete("Use " + nameof(BulkSendMailRequest) + " instead.")]
	public partial class MailObjectBulkSendMailRequest
	{
		public MailBasicSendMailRequest[] sendMailRequests;
		public virtual void Serialize(Beamable.Serialization.JsonSerializable.IStreamSerializer s)
		{
			s.SerializeArray("sendMailRequests", ref sendMailRequests);
		}
	}

	public partial class BulkSendMailRequest
	{
#pragma warning disable CS0618
		public static implicit operator MailObjectBulkSendMailRequest(BulkSendMailRequest req) =>
			new MailObjectBulkSendMailRequest
			{
				sendMailRequests = req.sendMailRequests.Select(r =>
				{
					MailBasicSendMailRequest converted = r;
					return converted;
				}).ToArray()
			};
#pragma warning restore CS0618

	}
	#endregion

	#region MailBasicSendMailRequest --> SendMailRequest
	[Obsolete("Use " + nameof(SendMailRequest) + " instead.")]
	public partial class MailBasicSendMailRequest
	{
		public OptionalAttachmentRequestArray attachments = new OptionalAttachmentRequestArray();
		public OptionalString body = new OptionalString();
		public OptionalLong bodyRef = new OptionalLong();
		public string category;
		public OptionalString expires = new OptionalString();
		public OptionalLong id = new OptionalLong();
		public OptionalPlayerReward playerRewards = new OptionalPlayerReward();
		public long receiverGamerTag;
		public OptionalMailRewards rewards = new OptionalMailRewards();
		public long senderGamerTag;
		public OptionalString subject = new OptionalString();
		public virtual void Serialize(Beamable.Serialization.JsonSerializable.IStreamSerializer s)
		{
			if ((s.HasKey("attachments")
				 || ((attachments != default(OptionalAttachmentRequestArray))
					 && attachments.HasValue)))
			{
				s.SerializeArray("attachments", ref attachments.Value);
				attachments.HasValue = true;
			}
			if ((s.HasKey("body")
				 || ((body != default(OptionalString))
					 && body.HasValue)))
			{
				s.Serialize("body", ref body.Value);
				body.HasValue = true;
			}
			if ((s.HasKey("bodyRef")
				 || ((bodyRef != default(OptionalLong))
					 && bodyRef.HasValue)))
			{
				s.Serialize("bodyRef", ref bodyRef.Value);
				bodyRef.HasValue = true;
			}
			s.Serialize("category", ref category);
			if ((s.HasKey("expires")
				 || ((expires != default(OptionalString))
					 && expires.HasValue)))
			{
				s.Serialize("expires", ref expires.Value);
				expires.HasValue = true;
			}
			if ((s.HasKey("id")
				 || ((id != default(OptionalLong))
					 && id.HasValue)))
			{
				s.Serialize("id", ref id.Value);
				id.HasValue = true;
			}
			s.Serialize("receiverGamerTag", ref receiverGamerTag);
			s.Serialize("senderGamerTag", ref senderGamerTag);
			if ((s.HasKey("subject")
				 || ((subject != default(OptionalString))
					 && subject.HasValue)))
			{
				s.Serialize("subject", ref subject.Value);
				subject.HasValue = true;
			}
		}
	}


	public partial class SendMailRequest
	{
#pragma warning disable CS0618
		public static implicit operator MailBasicSendMailRequest(SendMailRequest req) => new MailBasicSendMailRequest
		{
			attachments = req.attachments,
			body = req.body,
			bodyRef = req.bodyRef,
			category = req.category,
			expires = req.expires,
			id = req.id,
			playerRewards = req.playerRewards,
			receiverGamerTag = req.receiverGamerTag,
			rewards = req.rewards,
			senderGamerTag = req.senderGamerTag,
			subject = req.subject
		};
#pragma warning restore CS0618
	}

	#endregion

	#region MailObjectSendMailRequest --> SendMailRequest
	[Obsolete("Use " + nameof(SendMailRequest) + " instead.")]
	public partial class MailObjectSendMailRequest
	{
		public OptionalAttachmentRequestArray attachments = new OptionalAttachmentRequestArray();
		public OptionalString body = new OptionalString();
		public OptionalLong bodyRef = new OptionalLong();
		public string category;
		public OptionalString expires = new OptionalString();
		public OptionalLong id = new OptionalLong();
		public OptionalPlayerReward playerRewards = new OptionalPlayerReward();
		public long receiverGamerTag;
		public OptionalMailRewards rewards = new OptionalMailRewards();
		public long senderGamerTag;
		public OptionalString subject = new OptionalString();
		public virtual void Serialize(Beamable.Serialization.JsonSerializable.IStreamSerializer s)
		{
			if ((s.HasKey("attachments")
				 || ((attachments != default(OptionalAttachmentRequestArray))
					 && attachments.HasValue)))
			{
				s.SerializeArray("attachments", ref attachments.Value);
				attachments.HasValue = true;
			}
			if ((s.HasKey("body")
				 || ((body != default(OptionalString))
					 && body.HasValue)))
			{
				s.Serialize("body", ref body.Value);
				body.HasValue = true;
			}
			if ((s.HasKey("bodyRef")
				 || ((bodyRef != default(OptionalLong))
					 && bodyRef.HasValue)))
			{
				s.Serialize("bodyRef", ref bodyRef.Value);
				bodyRef.HasValue = true;
			}
			s.Serialize("category", ref category);
			if ((s.HasKey("expires")
				 || ((expires != default(OptionalString))
					 && expires.HasValue)))
			{
				s.Serialize("expires", ref expires.Value);
				expires.HasValue = true;
			}
			if ((s.HasKey("id")
				 || ((id != default(OptionalLong))
					 && id.HasValue)))
			{
				s.Serialize("id", ref id.Value);
				id.HasValue = true;
			}
			s.Serialize("receiverGamerTag", ref receiverGamerTag);
			s.Serialize("senderGamerTag", ref senderGamerTag);
			if ((s.HasKey("subject")
				 || ((subject != default(OptionalString))
					 && subject.HasValue)))
			{
				s.Serialize("subject", ref subject.Value);
				subject.HasValue = true;
			}
		}
	}


	public partial class SendMailRequest
	{
#pragma warning disable CS0618
		public static implicit operator MailObjectSendMailRequest(SendMailRequest req) => new MailObjectSendMailRequest
		{
			attachments = req.attachments,
			body = req.body,
			bodyRef = req.bodyRef,
			category = req.category,
			expires = req.expires,
			id = req.id,
			playerRewards = req.playerRewards,
			receiverGamerTag = req.receiverGamerTag,
			rewards = req.rewards,
			senderGamerTag = req.senderGamerTag,
			subject = req.subject
		};
#pragma warning restore CS0618
	}

	#endregion
}

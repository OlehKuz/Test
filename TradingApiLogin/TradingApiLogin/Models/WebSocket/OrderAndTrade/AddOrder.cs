

using System;

namespace TradingApiLogin.Models.WebSocket
{
    public class AddOrder:SocketMessage
    {
        public string MessageHeader { get; set; } = new MessageHeader().HeaderMessage;//= "Orders                        2000      1100                                     HDFC BANK HDFCBANK EQ                                         11  11-1        500180    0         P";//
       // string s = "Orders                        2000      1100                                     HDFC BANK HDFCBANK EQ                                         11  11-1        500180    0         P"
        public long ID { get; set; }
        public long TimeStamp { get; set; }
        public string LogTime { get; set; }
        //public string AlphaChar { get; set; }
        public long TransactionCode { get; set; } = 2000;
        public long ErrorCode { get; set; }
        public long TimeStamp1 { get; set; }
        public long TimeStamp2 { get; set; }
        public long UsId { get; set; } = 97;
        public string ParticipantType { get; set; }
        public long SubmitStatus { get; set; } = 1;
        public long OrderNumber { get; set; } = 0;
        public long BookType { get; set; } = 1;
        public long setBuySellIndicator { get; set; } = 1;
        public long Volume { get; set; } = 1;
        public string VolumeRemaining { get; set; } // = volume//long
        public string DisclosedVolume { get; set; } //= 3; // learn more - need to check minimum order quantity
        public long DisclosedVolumeRemaining { get; set; } //= 3;
        public long MinimumVolume { get; set; }
        public long VolumeFilledToday { get; set; }
        public long SetPrice { get; set; } 
        public long TriggerPrice { get; set; }
        public long Flags { get; set; }
        public long Broker { get; set; }
        public long TraderId { get; set; }
        public long BranchId { get; set; }
        public long Remarks { get; set; } = 0;
        public long EntryDateTime { get; set; } = 0;
        public long LastModifiedDateTime { get; set; } = 0;
        public string UsLoginId { get; set; } = "SER_CT2-T9072";
        public long CompetitorPeriod { get; set; } = 0;
        public string SolicitorPeriod { get; set; }//long
        public string ModifiedCancelledBy { get; set; } = "T";//char
        public long ReasonCode { get; set; } = 0;
        public long AuctionNumber { get; set; } = 0;
        public string CounterPartyBroker { get; set; }
        public string SuspendedSecurity { get; set; }//char
        public long GoodTillDate { get; set; } = 2;//1578009600;//= 1569801600; //not sure about it 
        public int Settlor { get; set; } = 0;//not sure about it
        public long ProClientIndicator { get; set; } = 1;
        public string SettlementPeriod { get; set; } //long= 0;
        public long CaLevel { get; set; } = 30;//client
        public string OpenClose { get; set; }//char
        public string CoverUnCover { get; set; }//char
        public string GiveUpFlag { get; set; }//char
        public long Purpose { get; set; } = 0;
        public long AdminUsId { get; set; } = 97;
        public string Reason { get; set; } = "^";
        public long Status { get; set; } = 0;
        public long ExpectedApproverId { get; set; } = 0;
        public string ActualApproverId { get; set; }//long
        public string ApproverRemarks { get; set; }
        public long OldVolume { get; set; }
        public long OldPrice { get; set; }
        public long CreatedBy { get; set; } = 97;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public string UpdatedBy { get; set; }//long //DateTime
        public string UpdatedAt { get; set; }//DateTime
        public long OrderType { get; set; } = 1;
        public string Filler { get; set; }
        public string InternalProductTypeForCashAndCarry{get;set;} = "N";//char
        public string Filler2 { get; set; }
        public string RowState { get; set; }//long
        public long IOC { get; set; } = 0; // not sure
        public string AuctionId { get; set; } //long
        public string BlockDeal { get; set; } = "N";//char
        public string RetentionType { get; set; } = "0";// = "GFD";
        public long Price { get; set; } //= 40000;// do i need to set it - it should take market price, or not? 
        public string SessionKey { get; set; } = "1626778972-01051108106";
    }
    public class MessageHeader : SocketMessage
    {
       
        public long MessageID { get; set; }// = 75;
        public string TableName { get; set; } = "Orders";
        public long TransactionCode { get; set; } = 2000;
        public long Direction { get; set; } = 1;
        public long InternalToken { get; set; } = 13;// = 461;// = 1734;   //BCCID
        public string ISINNumber { get; set; }
        public string InstrumentName { get; set; } = "ATUL LTD.";//bccinstrumentname
        public string Symbol { get; set; } = "ATUL";//?       //"COPPER";//bcccontractcode
        public string Series { get; set; } = "EQ";
        public long ExpiryDate { get; set; } //= 1580860800; //= 1569801600;
        public long StrikePrice { get; set; } //= -1;
        public string OptionType { get; set; }//char
        public long MessageType{ get; set; }
        public long Market { get; set; } = 1;
        public long Segment { get; set; } = 1;//6
        public long Source { get; set; } = 0;
        public long Destination { get; set; } //= 2;
        public long NSEToken { get; set; } = -1;//= 1400580;
        public long BSEToken { get; set; } = -1;//500027;//BCCToken == BCCInstrumentId  change places w nse token
        public long OriginTime { get; set; } = 0;
        public string Purpose { get; set; } = "P";//char
    }
}
//Exchange Name with ID All= 0        Market Name with ID     EQUITY= 1          Segment Name with ID  Equity = 1

/* 
 * BITFLEX Public API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Order
    /// </summary>
    [DataContract]
    public partial class Order :  IEquatable<Order>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets TradeType
        /// </summary>
        [DataMember(Name="tradeType", EmitDefaultValue=false)]
        public TradeType? TradeType { get; set; }
        /// <summary>
        /// Gets or Sets OrderType
        /// </summary>
        [DataMember(Name="orderType", EmitDefaultValue=false)]
        public OrderTypes? OrderType { get; set; }
        /// <summary>
        /// Gets or Sets OrderState
        /// </summary>
        [DataMember(Name="orderState", EmitDefaultValue=false)]
        public OrderState? OrderState { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Order" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="userId">userId.</param>
        /// <param name="tradeType">tradeType.</param>
        /// <param name="orderType">orderType.</param>
        /// <param name="orderState">orderState.</param>
        /// <param name="tradePairId">tradePairId.</param>
        /// <param name="amount">amount.</param>
        /// <param name="amountLeft">amountLeft.</param>
        /// <param name="price">price.</param>
        /// <param name="total">total.</param>
        /// <param name="totalLeft">totalLeft.</param>
        /// <param name="stopLossPrice">stopLossPrice.</param>
        /// <param name="takeProfitPrice">takeProfitPrice.</param>
        /// <param name="isMargin">isMargin.</param>
        /// <param name="liquidationPrice">liquidationPrice.</param>
        /// <param name="initialPrice">initialPrice.</param>
        /// <param name="leverage">leverage.</param>
        /// <param name="initialAmount">initialAmount.</param>
        /// <param name="pairCurrencyId">pairCurrencyId.</param>
        /// <param name="marketCurrencyId">marketCurrencyId.</param>
        /// <param name="dateCreated">dateCreated.</param>
        /// <param name="dateClosed">dateClosed.</param>
        /// <param name="dateOnMarket">dateOnMarket.</param>
        /// <param name="closed">closed.</param>
        /// <param name="concurrencyStamp">concurrencyStamp.</param>
        public Order(string id = default(string), string userId = default(string), TradeType? tradeType = default(TradeType?), OrderTypes? orderType = default(OrderTypes?), OrderState? orderState = default(OrderState?), string tradePairId = default(string), double amount = default(double), double amountLeft = default(double), double price = default(double), double total = default(double), double totalLeft = default(double), double stopLossPrice = default(double), double takeProfitPrice = default(double), bool isMargin = default(bool), double liquidationPrice = default(double), double initialPrice = default(double), int leverage = default(int), double initialAmount = default(double), string pairCurrencyId = default(string), string marketCurrencyId = default(string), long dateCreated = default(long), long? dateClosed = default(long?), long? dateOnMarket = default(long?), bool closed = default(bool), string concurrencyStamp = default(string))
        {
            this.Id = id;
            this.UserId = userId;
            this.TradeType = tradeType;
            this.OrderType = orderType;
            this.OrderState = orderState;
            this.TradePairId = tradePairId;
            this.Amount = amount;
            this.AmountLeft = amountLeft;
            this.Price = price;
            this.Total = total;
            this.TotalLeft = totalLeft;
            this.StopLossPrice = stopLossPrice;
            this.TakeProfitPrice = takeProfitPrice;
            this.IsMargin = isMargin;
            this.LiquidationPrice = liquidationPrice;
            this.InitialPrice = initialPrice;
            this.Leverage = leverage;
            this.InitialAmount = initialAmount;
            this.PairCurrencyId = pairCurrencyId;
            this.MarketCurrencyId = marketCurrencyId;
            this.DateCreated = dateCreated;
            this.DateClosed = dateClosed;
            this.DateOnMarket = dateOnMarket;
            this.Closed = closed;
            this.ConcurrencyStamp = concurrencyStamp;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=true)]
        public string UserId { get; set; }

        /// <summary>
        /// Gets or Sets TradePairId
        /// </summary>
        [DataMember(Name="tradePairId", EmitDefaultValue=true)]
        public string TradePairId { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public double Amount { get; set; }

        /// <summary>
        /// Gets or Sets AmountLeft
        /// </summary>
        [DataMember(Name="amountLeft", EmitDefaultValue=false)]
        public double AmountLeft { get; set; }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public double Price { get; set; }

        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public double Total { get; set; }

        /// <summary>
        /// Gets or Sets TotalLeft
        /// </summary>
        [DataMember(Name="totalLeft", EmitDefaultValue=false)]
        public double TotalLeft { get; set; }

        /// <summary>
        /// Gets or Sets StopLossPrice
        /// </summary>
        [DataMember(Name="stopLossPrice", EmitDefaultValue=false)]
        public double StopLossPrice { get; set; }

        /// <summary>
        /// Gets or Sets TakeProfitPrice
        /// </summary>
        [DataMember(Name="takeProfitPrice", EmitDefaultValue=false)]
        public double TakeProfitPrice { get; set; }

        /// <summary>
        /// Gets or Sets IsMargin
        /// </summary>
        [DataMember(Name="isMargin", EmitDefaultValue=false)]
        public bool IsMargin { get; set; }

        /// <summary>
        /// Gets or Sets LiquidationPrice
        /// </summary>
        [DataMember(Name="liquidationPrice", EmitDefaultValue=false)]
        public double LiquidationPrice { get; set; }

        /// <summary>
        /// Gets or Sets InitialPrice
        /// </summary>
        [DataMember(Name="initialPrice", EmitDefaultValue=false)]
        public double InitialPrice { get; set; }

        /// <summary>
        /// Gets or Sets Leverage
        /// </summary>
        [DataMember(Name="leverage", EmitDefaultValue=false)]
        public int Leverage { get; set; }

        /// <summary>
        /// Gets or Sets InitialAmount
        /// </summary>
        [DataMember(Name="initialAmount", EmitDefaultValue=false)]
        public double InitialAmount { get; set; }

        /// <summary>
        /// Gets or Sets PairCurrencyId
        /// </summary>
        [DataMember(Name="pairCurrencyId", EmitDefaultValue=true)]
        public string PairCurrencyId { get; set; }

        /// <summary>
        /// Gets or Sets MarketCurrencyId
        /// </summary>
        [DataMember(Name="marketCurrencyId", EmitDefaultValue=true)]
        public string MarketCurrencyId { get; set; }

        /// <summary>
        /// Gets or Sets DateCreated
        /// </summary>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public long DateCreated { get; set; }

        /// <summary>
        /// Gets or Sets DateClosed
        /// </summary>
        [DataMember(Name="dateClosed", EmitDefaultValue=true)]
        public long? DateClosed { get; set; }

        /// <summary>
        /// Gets or Sets DateOnMarket
        /// </summary>
        [DataMember(Name="dateOnMarket", EmitDefaultValue=true)]
        public long? DateOnMarket { get; set; }

        /// <summary>
        /// Gets or Sets Closed
        /// </summary>
        [DataMember(Name="closed", EmitDefaultValue=false)]
        public bool Closed { get; set; }

        /// <summary>
        /// Gets or Sets ConcurrencyStamp
        /// </summary>
        [DataMember(Name="concurrencyStamp", EmitDefaultValue=true)]
        public string ConcurrencyStamp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Order {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  TradeType: ").Append(TradeType).Append("\n");
            sb.Append("  OrderType: ").Append(OrderType).Append("\n");
            sb.Append("  OrderState: ").Append(OrderState).Append("\n");
            sb.Append("  TradePairId: ").Append(TradePairId).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  AmountLeft: ").Append(AmountLeft).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  TotalLeft: ").Append(TotalLeft).Append("\n");
            sb.Append("  StopLossPrice: ").Append(StopLossPrice).Append("\n");
            sb.Append("  TakeProfitPrice: ").Append(TakeProfitPrice).Append("\n");
            sb.Append("  IsMargin: ").Append(IsMargin).Append("\n");
            sb.Append("  LiquidationPrice: ").Append(LiquidationPrice).Append("\n");
            sb.Append("  InitialPrice: ").Append(InitialPrice).Append("\n");
            sb.Append("  Leverage: ").Append(Leverage).Append("\n");
            sb.Append("  InitialAmount: ").Append(InitialAmount).Append("\n");
            sb.Append("  PairCurrencyId: ").Append(PairCurrencyId).Append("\n");
            sb.Append("  MarketCurrencyId: ").Append(MarketCurrencyId).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateClosed: ").Append(DateClosed).Append("\n");
            sb.Append("  DateOnMarket: ").Append(DateOnMarket).Append("\n");
            sb.Append("  Closed: ").Append(Closed).Append("\n");
            sb.Append("  ConcurrencyStamp: ").Append(ConcurrencyStamp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Order);
        }

        /// <summary>
        /// Returns true if Order instances are equal
        /// </summary>
        /// <param name="input">Instance of Order to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Order input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.TradeType == input.TradeType ||
                    this.TradeType.Equals(input.TradeType)
                ) && 
                (
                    this.OrderType == input.OrderType ||
                    this.OrderType.Equals(input.OrderType)
                ) && 
                (
                    this.OrderState == input.OrderState ||
                    this.OrderState.Equals(input.OrderState)
                ) && 
                (
                    this.TradePairId == input.TradePairId ||
                    (this.TradePairId != null &&
                    this.TradePairId.Equals(input.TradePairId))
                ) && 
                (
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
                ) && 
                (
                    this.AmountLeft == input.AmountLeft ||
                    this.AmountLeft.Equals(input.AmountLeft)
                ) && 
                (
                    this.Price == input.Price ||
                    this.Price.Equals(input.Price)
                ) && 
                (
                    this.Total == input.Total ||
                    this.Total.Equals(input.Total)
                ) && 
                (
                    this.TotalLeft == input.TotalLeft ||
                    this.TotalLeft.Equals(input.TotalLeft)
                ) && 
                (
                    this.StopLossPrice == input.StopLossPrice ||
                    this.StopLossPrice.Equals(input.StopLossPrice)
                ) && 
                (
                    this.TakeProfitPrice == input.TakeProfitPrice ||
                    this.TakeProfitPrice.Equals(input.TakeProfitPrice)
                ) && 
                (
                    this.IsMargin == input.IsMargin ||
                    this.IsMargin.Equals(input.IsMargin)
                ) && 
                (
                    this.LiquidationPrice == input.LiquidationPrice ||
                    this.LiquidationPrice.Equals(input.LiquidationPrice)
                ) && 
                (
                    this.InitialPrice == input.InitialPrice ||
                    this.InitialPrice.Equals(input.InitialPrice)
                ) && 
                (
                    this.Leverage == input.Leverage ||
                    this.Leverage.Equals(input.Leverage)
                ) && 
                (
                    this.InitialAmount == input.InitialAmount ||
                    this.InitialAmount.Equals(input.InitialAmount)
                ) && 
                (
                    this.PairCurrencyId == input.PairCurrencyId ||
                    (this.PairCurrencyId != null &&
                    this.PairCurrencyId.Equals(input.PairCurrencyId))
                ) && 
                (
                    this.MarketCurrencyId == input.MarketCurrencyId ||
                    (this.MarketCurrencyId != null &&
                    this.MarketCurrencyId.Equals(input.MarketCurrencyId))
                ) && 
                (
                    this.DateCreated == input.DateCreated ||
                    this.DateCreated.Equals(input.DateCreated)
                ) && 
                (
                    this.DateClosed == input.DateClosed ||
                    (this.DateClosed != null &&
                    this.DateClosed.Equals(input.DateClosed))
                ) && 
                (
                    this.DateOnMarket == input.DateOnMarket ||
                    (this.DateOnMarket != null &&
                    this.DateOnMarket.Equals(input.DateOnMarket))
                ) && 
                (
                    this.Closed == input.Closed ||
                    this.Closed.Equals(input.Closed)
                ) && 
                (
                    this.ConcurrencyStamp == input.ConcurrencyStamp ||
                    (this.ConcurrencyStamp != null &&
                    this.ConcurrencyStamp.Equals(input.ConcurrencyStamp))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                hashCode = hashCode * 59 + this.TradeType.GetHashCode();
                hashCode = hashCode * 59 + this.OrderType.GetHashCode();
                hashCode = hashCode * 59 + this.OrderState.GetHashCode();
                if (this.TradePairId != null)
                    hashCode = hashCode * 59 + this.TradePairId.GetHashCode();
                hashCode = hashCode * 59 + this.Amount.GetHashCode();
                hashCode = hashCode * 59 + this.AmountLeft.GetHashCode();
                hashCode = hashCode * 59 + this.Price.GetHashCode();
                hashCode = hashCode * 59 + this.Total.GetHashCode();
                hashCode = hashCode * 59 + this.TotalLeft.GetHashCode();
                hashCode = hashCode * 59 + this.StopLossPrice.GetHashCode();
                hashCode = hashCode * 59 + this.TakeProfitPrice.GetHashCode();
                hashCode = hashCode * 59 + this.IsMargin.GetHashCode();
                hashCode = hashCode * 59 + this.LiquidationPrice.GetHashCode();
                hashCode = hashCode * 59 + this.InitialPrice.GetHashCode();
                hashCode = hashCode * 59 + this.Leverage.GetHashCode();
                hashCode = hashCode * 59 + this.InitialAmount.GetHashCode();
                if (this.PairCurrencyId != null)
                    hashCode = hashCode * 59 + this.PairCurrencyId.GetHashCode();
                if (this.MarketCurrencyId != null)
                    hashCode = hashCode * 59 + this.MarketCurrencyId.GetHashCode();
                hashCode = hashCode * 59 + this.DateCreated.GetHashCode();
                if (this.DateClosed != null)
                    hashCode = hashCode * 59 + this.DateClosed.GetHashCode();
                if (this.DateOnMarket != null)
                    hashCode = hashCode * 59 + this.DateOnMarket.GetHashCode();
                hashCode = hashCode * 59 + this.Closed.GetHashCode();
                if (this.ConcurrencyStamp != null)
                    hashCode = hashCode * 59 + this.ConcurrencyStamp.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}

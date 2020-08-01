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
    /// ApplicationUser
    /// </summary>
    [DataContract]
    public partial class ApplicationUser :  IEquatable<ApplicationUser>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public UserCategory? Category { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationUser" /> class.
        /// </summary>
        /// <param name="isGoogleAuthenticatorEnabled">isGoogleAuthenticatorEnabled.</param>
        /// <param name="googleAuthenticatorSecretKey">googleAuthenticatorSecretKey.</param>
        /// <param name="pinCode">pinCode.</param>
        /// <param name="lastIPAccess">lastIPAccess.</param>
        /// <param name="lastDateAccess">lastDateAccess.</param>
        /// <param name="isChatDisabled">isChatDisabled.</param>
        /// <param name="makerFee">makerFee.</param>
        /// <param name="takerFee">takerFee.</param>
        /// <param name="category">category.</param>
        /// <param name="isGoogleSignInAllowed">isGoogleSignInAllowed.</param>
        /// <param name="isFacebookSignInAllowed">isFacebookSignInAllowed.</param>
        /// <param name="affiliateUserId">affiliateUserId.</param>
        /// <param name="registrationDateTime">registrationDateTime.</param>
        /// <param name="id">id.</param>
        /// <param name="userName">userName.</param>
        /// <param name="normalizedUserName">normalizedUserName.</param>
        /// <param name="email">email.</param>
        /// <param name="normalizedEmail">normalizedEmail.</param>
        /// <param name="emailConfirmed">emailConfirmed.</param>
        /// <param name="passwordHash">passwordHash.</param>
        /// <param name="securityStamp">securityStamp.</param>
        /// <param name="concurrencyStamp">concurrencyStamp.</param>
        /// <param name="phoneNumber">phoneNumber.</param>
        /// <param name="phoneNumberConfirmed">phoneNumberConfirmed.</param>
        /// <param name="twoFactorEnabled">twoFactorEnabled.</param>
        /// <param name="lockoutEnd">lockoutEnd.</param>
        /// <param name="lockoutEnabled">lockoutEnabled.</param>
        /// <param name="accessFailedCount">accessFailedCount.</param>
        public ApplicationUser(bool isGoogleAuthenticatorEnabled = default(bool), string googleAuthenticatorSecretKey = default(string), string pinCode = default(string), string lastIPAccess = default(string), long? lastDateAccess = default(long?), bool isChatDisabled = default(bool), double? makerFee = default(double?), double? takerFee = default(double?), UserCategory? category = default(UserCategory?), bool isGoogleSignInAllowed = default(bool), bool isFacebookSignInAllowed = default(bool), string affiliateUserId = default(string), long registrationDateTime = default(long), string id = default(string), string userName = default(string), string normalizedUserName = default(string), string email = default(string), string normalizedEmail = default(string), bool emailConfirmed = default(bool), string passwordHash = default(string), string securityStamp = default(string), string concurrencyStamp = default(string), string phoneNumber = default(string), bool phoneNumberConfirmed = default(bool), bool twoFactorEnabled = default(bool), DateTime? lockoutEnd = default(DateTime?), bool lockoutEnabled = default(bool), int accessFailedCount = default(int))
        {
            this.IsGoogleAuthenticatorEnabled = isGoogleAuthenticatorEnabled;
            this.GoogleAuthenticatorSecretKey = googleAuthenticatorSecretKey;
            this.PinCode = pinCode;
            this.LastIPAccess = lastIPAccess;
            this.LastDateAccess = lastDateAccess;
            this.IsChatDisabled = isChatDisabled;
            this.MakerFee = makerFee;
            this.TakerFee = takerFee;
            this.Category = category;
            this.IsGoogleSignInAllowed = isGoogleSignInAllowed;
            this.IsFacebookSignInAllowed = isFacebookSignInAllowed;
            this.AffiliateUserId = affiliateUserId;
            this.RegistrationDateTime = registrationDateTime;
            this.Id = id;
            this.UserName = userName;
            this.NormalizedUserName = normalizedUserName;
            this.Email = email;
            this.NormalizedEmail = normalizedEmail;
            this.EmailConfirmed = emailConfirmed;
            this.PasswordHash = passwordHash;
            this.SecurityStamp = securityStamp;
            this.ConcurrencyStamp = concurrencyStamp;
            this.PhoneNumber = phoneNumber;
            this.PhoneNumberConfirmed = phoneNumberConfirmed;
            this.TwoFactorEnabled = twoFactorEnabled;
            this.LockoutEnd = lockoutEnd;
            this.LockoutEnabled = lockoutEnabled;
            this.AccessFailedCount = accessFailedCount;
        }
        
        /// <summary>
        /// Gets or Sets IsGoogleAuthenticatorEnabled
        /// </summary>
        [DataMember(Name="isGoogleAuthenticatorEnabled", EmitDefaultValue=false)]
        public bool IsGoogleAuthenticatorEnabled { get; set; }

        /// <summary>
        /// Gets or Sets GoogleAuthenticatorSecretKey
        /// </summary>
        [DataMember(Name="googleAuthenticatorSecretKey", EmitDefaultValue=true)]
        public string GoogleAuthenticatorSecretKey { get; set; }

        /// <summary>
        /// Gets or Sets PinCode
        /// </summary>
        [DataMember(Name="pinCode", EmitDefaultValue=true)]
        public string PinCode { get; set; }

        /// <summary>
        /// Gets or Sets LastIPAccess
        /// </summary>
        [DataMember(Name="lastIPAccess", EmitDefaultValue=true)]
        public string LastIPAccess { get; set; }

        /// <summary>
        /// Gets or Sets LastDateAccess
        /// </summary>
        [DataMember(Name="lastDateAccess", EmitDefaultValue=true)]
        public long? LastDateAccess { get; set; }

        /// <summary>
        /// Gets or Sets IsChatDisabled
        /// </summary>
        [DataMember(Name="isChatDisabled", EmitDefaultValue=false)]
        public bool IsChatDisabled { get; set; }

        /// <summary>
        /// Gets or Sets MakerFee
        /// </summary>
        [DataMember(Name="makerFee", EmitDefaultValue=true)]
        public double? MakerFee { get; set; }

        /// <summary>
        /// Gets or Sets TakerFee
        /// </summary>
        [DataMember(Name="takerFee", EmitDefaultValue=true)]
        public double? TakerFee { get; set; }

        /// <summary>
        /// Gets or Sets IsGoogleSignInAllowed
        /// </summary>
        [DataMember(Name="isGoogleSignInAllowed", EmitDefaultValue=false)]
        public bool IsGoogleSignInAllowed { get; set; }

        /// <summary>
        /// Gets or Sets IsFacebookSignInAllowed
        /// </summary>
        [DataMember(Name="isFacebookSignInAllowed", EmitDefaultValue=false)]
        public bool IsFacebookSignInAllowed { get; set; }

        /// <summary>
        /// Gets or Sets AffiliateUserId
        /// </summary>
        [DataMember(Name="affiliateUserId", EmitDefaultValue=true)]
        public string AffiliateUserId { get; set; }

        /// <summary>
        /// Gets or Sets RegistrationDateTime
        /// </summary>
        [DataMember(Name="registrationDateTime", EmitDefaultValue=false)]
        public long RegistrationDateTime { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets UserName
        /// </summary>
        [DataMember(Name="userName", EmitDefaultValue=true)]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or Sets NormalizedUserName
        /// </summary>
        [DataMember(Name="normalizedUserName", EmitDefaultValue=true)]
        public string NormalizedUserName { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=true)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets NormalizedEmail
        /// </summary>
        [DataMember(Name="normalizedEmail", EmitDefaultValue=true)]
        public string NormalizedEmail { get; set; }

        /// <summary>
        /// Gets or Sets EmailConfirmed
        /// </summary>
        [DataMember(Name="emailConfirmed", EmitDefaultValue=false)]
        public bool EmailConfirmed { get; set; }

        /// <summary>
        /// Gets or Sets PasswordHash
        /// </summary>
        [DataMember(Name="passwordHash", EmitDefaultValue=true)]
        public string PasswordHash { get; set; }

        /// <summary>
        /// Gets or Sets SecurityStamp
        /// </summary>
        [DataMember(Name="securityStamp", EmitDefaultValue=true)]
        public string SecurityStamp { get; set; }

        /// <summary>
        /// Gets or Sets ConcurrencyStamp
        /// </summary>
        [DataMember(Name="concurrencyStamp", EmitDefaultValue=true)]
        public string ConcurrencyStamp { get; set; }

        /// <summary>
        /// Gets or Sets PhoneNumber
        /// </summary>
        [DataMember(Name="phoneNumber", EmitDefaultValue=true)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets PhoneNumberConfirmed
        /// </summary>
        [DataMember(Name="phoneNumberConfirmed", EmitDefaultValue=false)]
        public bool PhoneNumberConfirmed { get; set; }

        /// <summary>
        /// Gets or Sets TwoFactorEnabled
        /// </summary>
        [DataMember(Name="twoFactorEnabled", EmitDefaultValue=false)]
        public bool TwoFactorEnabled { get; set; }

        /// <summary>
        /// Gets or Sets LockoutEnd
        /// </summary>
        [DataMember(Name="lockoutEnd", EmitDefaultValue=true)]
        public DateTime? LockoutEnd { get; set; }

        /// <summary>
        /// Gets or Sets LockoutEnabled
        /// </summary>
        [DataMember(Name="lockoutEnabled", EmitDefaultValue=false)]
        public bool LockoutEnabled { get; set; }

        /// <summary>
        /// Gets or Sets AccessFailedCount
        /// </summary>
        [DataMember(Name="accessFailedCount", EmitDefaultValue=false)]
        public int AccessFailedCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplicationUser {\n");
            sb.Append("  IsGoogleAuthenticatorEnabled: ").Append(IsGoogleAuthenticatorEnabled).Append("\n");
            sb.Append("  GoogleAuthenticatorSecretKey: ").Append(GoogleAuthenticatorSecretKey).Append("\n");
            sb.Append("  PinCode: ").Append(PinCode).Append("\n");
            sb.Append("  LastIPAccess: ").Append(LastIPAccess).Append("\n");
            sb.Append("  LastDateAccess: ").Append(LastDateAccess).Append("\n");
            sb.Append("  IsChatDisabled: ").Append(IsChatDisabled).Append("\n");
            sb.Append("  MakerFee: ").Append(MakerFee).Append("\n");
            sb.Append("  TakerFee: ").Append(TakerFee).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  IsGoogleSignInAllowed: ").Append(IsGoogleSignInAllowed).Append("\n");
            sb.Append("  IsFacebookSignInAllowed: ").Append(IsFacebookSignInAllowed).Append("\n");
            sb.Append("  AffiliateUserId: ").Append(AffiliateUserId).Append("\n");
            sb.Append("  RegistrationDateTime: ").Append(RegistrationDateTime).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  NormalizedUserName: ").Append(NormalizedUserName).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  NormalizedEmail: ").Append(NormalizedEmail).Append("\n");
            sb.Append("  EmailConfirmed: ").Append(EmailConfirmed).Append("\n");
            sb.Append("  PasswordHash: ").Append(PasswordHash).Append("\n");
            sb.Append("  SecurityStamp: ").Append(SecurityStamp).Append("\n");
            sb.Append("  ConcurrencyStamp: ").Append(ConcurrencyStamp).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  PhoneNumberConfirmed: ").Append(PhoneNumberConfirmed).Append("\n");
            sb.Append("  TwoFactorEnabled: ").Append(TwoFactorEnabled).Append("\n");
            sb.Append("  LockoutEnd: ").Append(LockoutEnd).Append("\n");
            sb.Append("  LockoutEnabled: ").Append(LockoutEnabled).Append("\n");
            sb.Append("  AccessFailedCount: ").Append(AccessFailedCount).Append("\n");
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
            return this.Equals(input as ApplicationUser);
        }

        /// <summary>
        /// Returns true if ApplicationUser instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicationUser to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationUser input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsGoogleAuthenticatorEnabled == input.IsGoogleAuthenticatorEnabled ||
                    this.IsGoogleAuthenticatorEnabled.Equals(input.IsGoogleAuthenticatorEnabled)
                ) && 
                (
                    this.GoogleAuthenticatorSecretKey == input.GoogleAuthenticatorSecretKey ||
                    (this.GoogleAuthenticatorSecretKey != null &&
                    this.GoogleAuthenticatorSecretKey.Equals(input.GoogleAuthenticatorSecretKey))
                ) && 
                (
                    this.PinCode == input.PinCode ||
                    (this.PinCode != null &&
                    this.PinCode.Equals(input.PinCode))
                ) && 
                (
                    this.LastIPAccess == input.LastIPAccess ||
                    (this.LastIPAccess != null &&
                    this.LastIPAccess.Equals(input.LastIPAccess))
                ) && 
                (
                    this.LastDateAccess == input.LastDateAccess ||
                    (this.LastDateAccess != null &&
                    this.LastDateAccess.Equals(input.LastDateAccess))
                ) && 
                (
                    this.IsChatDisabled == input.IsChatDisabled ||
                    this.IsChatDisabled.Equals(input.IsChatDisabled)
                ) && 
                (
                    this.MakerFee == input.MakerFee ||
                    (this.MakerFee != null &&
                    this.MakerFee.Equals(input.MakerFee))
                ) && 
                (
                    this.TakerFee == input.TakerFee ||
                    (this.TakerFee != null &&
                    this.TakerFee.Equals(input.TakerFee))
                ) && 
                (
                    this.Category == input.Category ||
                    this.Category.Equals(input.Category)
                ) && 
                (
                    this.IsGoogleSignInAllowed == input.IsGoogleSignInAllowed ||
                    this.IsGoogleSignInAllowed.Equals(input.IsGoogleSignInAllowed)
                ) && 
                (
                    this.IsFacebookSignInAllowed == input.IsFacebookSignInAllowed ||
                    this.IsFacebookSignInAllowed.Equals(input.IsFacebookSignInAllowed)
                ) && 
                (
                    this.AffiliateUserId == input.AffiliateUserId ||
                    (this.AffiliateUserId != null &&
                    this.AffiliateUserId.Equals(input.AffiliateUserId))
                ) && 
                (
                    this.RegistrationDateTime == input.RegistrationDateTime ||
                    this.RegistrationDateTime.Equals(input.RegistrationDateTime)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
                ) && 
                (
                    this.NormalizedUserName == input.NormalizedUserName ||
                    (this.NormalizedUserName != null &&
                    this.NormalizedUserName.Equals(input.NormalizedUserName))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.NormalizedEmail == input.NormalizedEmail ||
                    (this.NormalizedEmail != null &&
                    this.NormalizedEmail.Equals(input.NormalizedEmail))
                ) && 
                (
                    this.EmailConfirmed == input.EmailConfirmed ||
                    this.EmailConfirmed.Equals(input.EmailConfirmed)
                ) && 
                (
                    this.PasswordHash == input.PasswordHash ||
                    (this.PasswordHash != null &&
                    this.PasswordHash.Equals(input.PasswordHash))
                ) && 
                (
                    this.SecurityStamp == input.SecurityStamp ||
                    (this.SecurityStamp != null &&
                    this.SecurityStamp.Equals(input.SecurityStamp))
                ) && 
                (
                    this.ConcurrencyStamp == input.ConcurrencyStamp ||
                    (this.ConcurrencyStamp != null &&
                    this.ConcurrencyStamp.Equals(input.ConcurrencyStamp))
                ) && 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && 
                (
                    this.PhoneNumberConfirmed == input.PhoneNumberConfirmed ||
                    this.PhoneNumberConfirmed.Equals(input.PhoneNumberConfirmed)
                ) && 
                (
                    this.TwoFactorEnabled == input.TwoFactorEnabled ||
                    this.TwoFactorEnabled.Equals(input.TwoFactorEnabled)
                ) && 
                (
                    this.LockoutEnd == input.LockoutEnd ||
                    (this.LockoutEnd != null &&
                    this.LockoutEnd.Equals(input.LockoutEnd))
                ) && 
                (
                    this.LockoutEnabled == input.LockoutEnabled ||
                    this.LockoutEnabled.Equals(input.LockoutEnabled)
                ) && 
                (
                    this.AccessFailedCount == input.AccessFailedCount ||
                    this.AccessFailedCount.Equals(input.AccessFailedCount)
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
                hashCode = hashCode * 59 + this.IsGoogleAuthenticatorEnabled.GetHashCode();
                if (this.GoogleAuthenticatorSecretKey != null)
                    hashCode = hashCode * 59 + this.GoogleAuthenticatorSecretKey.GetHashCode();
                if (this.PinCode != null)
                    hashCode = hashCode * 59 + this.PinCode.GetHashCode();
                if (this.LastIPAccess != null)
                    hashCode = hashCode * 59 + this.LastIPAccess.GetHashCode();
                if (this.LastDateAccess != null)
                    hashCode = hashCode * 59 + this.LastDateAccess.GetHashCode();
                hashCode = hashCode * 59 + this.IsChatDisabled.GetHashCode();
                if (this.MakerFee != null)
                    hashCode = hashCode * 59 + this.MakerFee.GetHashCode();
                if (this.TakerFee != null)
                    hashCode = hashCode * 59 + this.TakerFee.GetHashCode();
                hashCode = hashCode * 59 + this.Category.GetHashCode();
                hashCode = hashCode * 59 + this.IsGoogleSignInAllowed.GetHashCode();
                hashCode = hashCode * 59 + this.IsFacebookSignInAllowed.GetHashCode();
                if (this.AffiliateUserId != null)
                    hashCode = hashCode * 59 + this.AffiliateUserId.GetHashCode();
                hashCode = hashCode * 59 + this.RegistrationDateTime.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.UserName != null)
                    hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.NormalizedUserName != null)
                    hashCode = hashCode * 59 + this.NormalizedUserName.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.NormalizedEmail != null)
                    hashCode = hashCode * 59 + this.NormalizedEmail.GetHashCode();
                hashCode = hashCode * 59 + this.EmailConfirmed.GetHashCode();
                if (this.PasswordHash != null)
                    hashCode = hashCode * 59 + this.PasswordHash.GetHashCode();
                if (this.SecurityStamp != null)
                    hashCode = hashCode * 59 + this.SecurityStamp.GetHashCode();
                if (this.ConcurrencyStamp != null)
                    hashCode = hashCode * 59 + this.ConcurrencyStamp.GetHashCode();
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
                hashCode = hashCode * 59 + this.PhoneNumberConfirmed.GetHashCode();
                hashCode = hashCode * 59 + this.TwoFactorEnabled.GetHashCode();
                if (this.LockoutEnd != null)
                    hashCode = hashCode * 59 + this.LockoutEnd.GetHashCode();
                hashCode = hashCode * 59 + this.LockoutEnabled.GetHashCode();
                hashCode = hashCode * 59 + this.AccessFailedCount.GetHashCode();
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

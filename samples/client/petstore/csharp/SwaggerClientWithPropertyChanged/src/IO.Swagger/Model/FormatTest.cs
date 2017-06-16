/* 
 * Swagger Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * OpenAPI spec version: 1.0.0
 * Contact: apiteam@swagger.io
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using PropertyChanged;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// FormatTest
    /// </summary>
    [DataContract]
    [ImplementPropertyChanged]
    public partial class FormatTest :  IEquatable<FormatTest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormatTest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FormatTest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FormatTest" /> class.
        /// </summary>
        /// <param name="Integer">Integer.</param>
        /// <param name="Int32">Int32.</param>
        /// <param name="Int64">Int64.</param>
        /// <param name="Number">Number (required).</param>
        /// <param name="_Float">_Float.</param>
        /// <param name="_Double">_Double.</param>
        /// <param name="_String">_String.</param>
        /// <param name="_Byte">_Byte (required).</param>
        /// <param name="Binary">Binary.</param>
        /// <param name="Date">Date (required).</param>
        /// <param name="DateTime">DateTime.</param>
        /// <param name="Uuid">Uuid.</param>
        /// <param name="Password">Password (required).</param>
        public FormatTest(int? Integer = default(int?), int? Int32 = default(int?), long? Int64 = default(long?), decimal? Number = default(decimal?), float? _Float = default(float?), double? _Double = default(double?), string _String = default(string), byte[] _Byte = default(byte[]), byte[] Binary = default(byte[]), DateTime? Date = default(DateTime?), DateTime? DateTime = default(DateTime?), Guid? Uuid = default(Guid?), string Password = default(string))
        {
            // to ensure "Number" is required (not null)
            if (Number == null)
            {
                throw new InvalidDataException("Number is a required property for FormatTest and cannot be null");
            }
            else
            {
                this.Number = Number;
            }
            // to ensure "_Byte" is required (not null)
            if (_Byte == null)
            {
                throw new InvalidDataException("_Byte is a required property for FormatTest and cannot be null");
            }
            else
            {
                this._Byte = _Byte;
            }
            // to ensure "Date" is required (not null)
            if (Date == null)
            {
                throw new InvalidDataException("Date is a required property for FormatTest and cannot be null");
            }
            else
            {
                this.Date = Date;
            }
            // to ensure "Password" is required (not null)
            if (Password == null)
            {
                throw new InvalidDataException("Password is a required property for FormatTest and cannot be null");
            }
            else
            {
                this.Password = Password;
            }
            this.Integer = Integer;
            this.Int32 = Int32;
            this.Int64 = Int64;
            this._Float = _Float;
            this._Double = _Double;
            this._String = _String;
            this.Binary = Binary;
            this.DateTime = DateTime;
            this.Uuid = Uuid;
        }
        
        /// <summary>
        /// Gets or Sets Integer
        /// </summary>
        [DataMember(Name="integer", EmitDefaultValue=false)]
        public int? Integer { get; set; }

        /// <summary>
        /// Gets or Sets Int32
        /// </summary>
        [DataMember(Name="int32", EmitDefaultValue=false)]
        public int? Int32 { get; set; }

        /// <summary>
        /// Gets or Sets Int64
        /// </summary>
        [DataMember(Name="int64", EmitDefaultValue=false)]
        public long? Int64 { get; set; }

        /// <summary>
        /// Gets or Sets Number
        /// </summary>
        [DataMember(Name="number", EmitDefaultValue=false)]
        public decimal? Number { get; set; }

        /// <summary>
        /// Gets or Sets _Float
        /// </summary>
        [DataMember(Name="float", EmitDefaultValue=false)]
        public float? _Float { get; set; }

        /// <summary>
        /// Gets or Sets _Double
        /// </summary>
        [DataMember(Name="double", EmitDefaultValue=false)]
        public double? _Double { get; set; }

        /// <summary>
        /// Gets or Sets _String
        /// </summary>
        [DataMember(Name="string", EmitDefaultValue=false)]
        public string _String { get; set; }

        /// <summary>
        /// Gets or Sets _Byte
        /// </summary>
        [DataMember(Name="byte", EmitDefaultValue=false)]
        public byte[] _Byte { get; set; }

        /// <summary>
        /// Gets or Sets Binary
        /// </summary>
        [DataMember(Name="binary", EmitDefaultValue=false)]
        public byte[] Binary { get; set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name="date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Gets or Sets DateTime
        /// </summary>
        [DataMember(Name="dateTime", EmitDefaultValue=false)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// Gets or Sets Uuid
        /// </summary>
        [DataMember(Name="uuid", EmitDefaultValue=false)]
        public Guid? Uuid { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FormatTest {\n");
            sb.Append("  Integer: ").Append(Integer).Append("\n");
            sb.Append("  Int32: ").Append(Int32).Append("\n");
            sb.Append("  Int64: ").Append(Int64).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  _Float: ").Append(_Float).Append("\n");
            sb.Append("  _Double: ").Append(_Double).Append("\n");
            sb.Append("  _String: ").Append(_String).Append("\n");
            sb.Append("  _Byte: ").Append(_Byte).Append("\n");
            sb.Append("  Binary: ").Append(Binary).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  DateTime: ").Append(DateTime).Append("\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as FormatTest);
        }

        /// <summary>
        /// Returns true if FormatTest instances are equal
        /// </summary>
        /// <param name="other">Instance of FormatTest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FormatTest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Integer == other.Integer ||
                    this.Integer != null &&
                    this.Integer.Equals(other.Integer)
                ) && 
                (
                    this.Int32 == other.Int32 ||
                    this.Int32 != null &&
                    this.Int32.Equals(other.Int32)
                ) && 
                (
                    this.Int64 == other.Int64 ||
                    this.Int64 != null &&
                    this.Int64.Equals(other.Int64)
                ) && 
                (
                    this.Number == other.Number ||
                    this.Number != null &&
                    this.Number.Equals(other.Number)
                ) && 
                (
                    this._Float == other._Float ||
                    this._Float != null &&
                    this._Float.Equals(other._Float)
                ) && 
                (
                    this._Double == other._Double ||
                    this._Double != null &&
                    this._Double.Equals(other._Double)
                ) && 
                (
                    this._String == other._String ||
                    this._String != null &&
                    this._String.Equals(other._String)
                ) && 
                (
                    this._Byte == other._Byte ||
                    this._Byte != null &&
                    this._Byte.Equals(other._Byte)
                ) && 
                (
                    this.Binary == other.Binary ||
                    this.Binary != null &&
                    this.Binary.Equals(other.Binary)
                ) && 
                (
                    this.Date == other.Date ||
                    this.Date != null &&
                    this.Date.Equals(other.Date)
                ) && 
                (
                    this.DateTime == other.DateTime ||
                    this.DateTime != null &&
                    this.DateTime.Equals(other.DateTime)
                ) && 
                (
                    this.Uuid == other.Uuid ||
                    this.Uuid != null &&
                    this.Uuid.Equals(other.Uuid)
                ) && 
                (
                    this.Password == other.Password ||
                    this.Password != null &&
                    this.Password.Equals(other.Password)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Integer != null)
                    hash = hash * 59 + this.Integer.GetHashCode();
                if (this.Int32 != null)
                    hash = hash * 59 + this.Int32.GetHashCode();
                if (this.Int64 != null)
                    hash = hash * 59 + this.Int64.GetHashCode();
                if (this.Number != null)
                    hash = hash * 59 + this.Number.GetHashCode();
                if (this._Float != null)
                    hash = hash * 59 + this._Float.GetHashCode();
                if (this._Double != null)
                    hash = hash * 59 + this._Double.GetHashCode();
                if (this._String != null)
                    hash = hash * 59 + this._String.GetHashCode();
                if (this._Byte != null)
                    hash = hash * 59 + this._Byte.GetHashCode();
                if (this.Binary != null)
                    hash = hash * 59 + this.Binary.GetHashCode();
                if (this.Date != null)
                    hash = hash * 59 + this.Date.GetHashCode();
                if (this.DateTime != null)
                    hash = hash * 59 + this.DateTime.GetHashCode();
                if (this.Uuid != null)
                    hash = hash * 59 + this.Uuid.GetHashCode();
                if (this.Password != null)
                    hash = hash * 59 + this.Password.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// Property changed event handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Trigger when a property changed
        /// </summary>
        /// <param name="propertyName">Property Name</param>
        public virtual void OnPropertyChanged(string propertyName)
        {
            // NOTE: property changed is handled via "code weaving" using Fody.
            // Properties with setters are modified at compile time to notify of changes.
            var propertyChanged = PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // Integer (int?) maximum
            if(this.Integer > (int?)100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Integer, must be a value less than or equal to 100.", new [] { "Integer" });
            }

            // Integer (int?) minimum
            if(this.Integer < (int?)10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Integer, must be a value greater than or equal to 10.", new [] { "Integer" });
            }

            // Int32 (int?) maximum
            if(this.Int32 > (int?)200)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Int32, must be a value less than or equal to 200.", new [] { "Int32" });
            }

            // Int32 (int?) minimum
            if(this.Int32 < (int?)20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Int32, must be a value greater than or equal to 20.", new [] { "Int32" });
            }

            // Number (decimal?) maximum
            if(this.Number > (decimal?)543.2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Number, must be a value less than or equal to 543.2.", new [] { "Number" });
            }

            // Number (decimal?) minimum
            if(this.Number < (decimal?)32.1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Number, must be a value greater than or equal to 32.1.", new [] { "Number" });
            }

            // _Float (float?) maximum
            if(this._Float > (float?)987.6)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for _Float, must be a value less than or equal to 987.6.", new [] { "_Float" });
            }

            // _Float (float?) minimum
            if(this._Float < (float?)54.3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for _Float, must be a value greater than or equal to 54.3.", new [] { "_Float" });
            }

            // _Double (double?) maximum
            if(this._Double > (double?)123.4)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for _Double, must be a value less than or equal to 123.4.", new [] { "_Double" });
            }

            // _Double (double?) minimum
            if(this._Double < (double?)67.8)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for _Double, must be a value greater than or equal to 67.8.", new [] { "_Double" });
            }

            // _String (string) pattern
            Regex regex_String = new Regex(@"[a-z]", RegexOptions.CultureInvariant | RegexOptions.IgnoreCase);
            if (false == regex_String.Match(this._String).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for _String, must match a pattern of /[a-z]/i.", new [] { "_String" });
            }

            // Password (string) maxLength
            if(this.Password != null && this.Password.Length > 64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Password, length must be less than 64.", new [] { "Password" });
            }

            // Password (string) minLength
            if(this.Password != null && this.Password.Length < 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Password, length must be greater than 10.", new [] { "Password" });
            }

            yield break;
        }
    }

}

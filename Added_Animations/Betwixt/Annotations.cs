// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2017
// ***********************************************************************
// <copyright file="Annotations.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;

#pragma warning disable 1591
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedParameter.Local
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable IntroduceOptionalParameters.Global
// ReSharper disable MemberCanBeProtected.Global
// ReSharper disable InconsistentNaming

namespace Zeroit.Framework.Transitions.Betwixt.Annotations
{
    /// <summary>
    /// Indicates that the value of the marked element could be <c>null</c> sometimes,
    /// so the check for <c>null</c> is necessary before its usage
    /// </summary>
    /// <seealso cref="System.Attribute" />
    /// <example>
    ///   <code>
    /// [CanBeNull] public object Test() { return null; }
    /// public void UseTest() {
    /// var p = Test();
    /// var s = p.ToString(); // Warning: Possible 'System.NullReferenceException'
    /// }
    /// </code>
    /// </example>
    [AttributeUsage(
    AttributeTargets.Method | AttributeTargets.Parameter |
    AttributeTargets.Property | AttributeTargets.Delegate |
    AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
  internal sealed class CanBeNullAttribute : Attribute { }

    /// <summary>
    /// Indicates that the value of the marked element could never be <c>null</c>
    /// </summary>
    /// <seealso cref="System.Attribute" />
    /// <example>
    ///   <code>
    /// [NotNull] public object Foo() {
    /// return null; // Warning: Possible 'null' assignment
    /// }
    /// </code>
    /// </example>
    [AttributeUsage(
    AttributeTargets.Method | AttributeTargets.Parameter |
    AttributeTargets.Property | AttributeTargets.Delegate |
    AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
  internal sealed class NotNullAttribute : Attribute { }

    /// <summary>
    /// Indicates that the marked method builds string by format pattern and (optional) arguments.
    /// Parameter, which contains format string, should be given in constructor. The format string
    /// should be in <see cref="string.Format(IFormatProvider,string,object[])" />-like form
    /// </summary>
    /// <seealso cref="System.Attribute" />
    /// <example>
    ///   <code>
    /// [StringFormatMethod("message")]
    /// public void ShowError(string message, params object[] args) { /* do something */ }
    /// public void Foo() {
    /// ShowError("Failed: {0}"); // Warning: Non-existing argument in format string
    /// }
    /// </code>
    /// </example>
    [AttributeUsage(
    AttributeTargets.Constructor | AttributeTargets.Method,
    AllowMultiple = false, Inherited = true)]
  internal sealed class StringFormatMethodAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StringFormatMethodAttribute"/> class.
        /// </summary>
        /// <param name="formatParameterName">Specifies which parameter of an annotated method should be treated as format-string</param>
        public StringFormatMethodAttribute(string formatParameterName)
    {
      FormatParameterName = formatParameterName;
    }

        /// <summary>
        /// Gets the name of the format parameter.
        /// </summary>
        /// <value>The name of the format parameter.</value>
        public string FormatParameterName { get; private set; }
  }

    /// <summary>
    /// Indicates that the function argument should be string literal and match one
    /// of the parameters of the caller function. For example, ReSharper annotates
    /// the parameter of <see cref="System.ArgumentNullException" />
    /// </summary>
    /// <seealso cref="System.Attribute" />
    /// <example>
    ///   <code>
    /// public void Foo(string param) {
    /// if (param == null)
    /// throw new ArgumentNullException("par"); // Warning: Cannot resolve symbol
    /// }
    /// </code>
    /// </example>
    [AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false, Inherited = true)]
  internal sealed class InvokerParameterNameAttribute : Attribute { }

    /// <summary>
    /// Indicates that the method is contained in a type that implements
    /// <see cref="System.ComponentModel.INotifyPropertyChanged" /> interface
    /// and this method is used to notify that some property value changed
    /// </summary>
    /// <seealso cref="System.Attribute" />
    /// <example>
    ///   <code>
    /// public class Foo : INotifyPropertyChanged {
    /// public event PropertyChangedEventHandler PropertyChanged;
    /// [NotifyPropertyChangedInvocator]
    /// protected virtual void NotifyChanged(string propertyName) { ... }
    /// private string _name;
    /// public string Name {
    /// get { return _name; }
    /// set { _name = value; NotifyChanged("LastName"); /* Warning */ }
    /// }
    /// }
    /// </code>
    /// Examples of generated notifications:
    /// <list><item><c>NotifyChanged("Property")</c></item><item><c>NotifyChanged(() =&gt; Property)</c></item><item><c>NotifyChanged((VM x) =&gt; x.Property)</c></item><item><c>SetProperty(ref myField, value, "Property")</c></item></list></example>
    /// <remarks>The method should be non-static and conform to one of the supported signatures:
    /// <list><item><c>NotifyChanged(string)</c></item><item><c>NotifyChanged(params string[])</c></item><item><c>NotifyChanged{T}(Expression{Func{T}})</c></item><item><c>NotifyChanged{T,U}(Expression{Func{T,U}})</c></item><item><c>SetProperty{T}(ref T, T, string)</c></item></list></remarks>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
  internal sealed class NotifyPropertyChangedInvocatorAttribute : Attribute
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotifyPropertyChangedInvocatorAttribute"/> class.
        /// </summary>
        public NotifyPropertyChangedInvocatorAttribute() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NotifyPropertyChangedInvocatorAttribute"/> class.
        /// </summary>
        /// <param name="parameterName">Name of the parameter.</param>
        public NotifyPropertyChangedInvocatorAttribute(string parameterName)
    {
      ParameterName = parameterName;
    }

        /// <summary>
        /// Gets the name of the parameter.
        /// </summary>
        /// <value>The name of the parameter.</value>
        public string ParameterName { get; private set; }
  }

    /// <summary>
    /// Describes dependency between method input and output
    /// </summary>
    /// <seealso cref="System.Attribute" />
    /// <syntax>
    ///   <p>Function Definition Table syntax:</p>
    ///   <list>
    ///     <item>FDT      ::= FDTRow [;FDTRow]*</item>
    ///     <item>FDTRow   ::= Input =&gt; Output | Output &lt;= Input</item>
    ///     <item>Input    ::= ParameterName: Value [, Input]*</item>
    ///     <item>Output   ::= [ParameterName: Value]* {halt|stop|void|nothing|Value}</item>
    ///     <item>Value    ::= true | false | null | notnull | canbenull</item>
    ///   </list>
    /// If method has single input parameter, it's name could be omitted.<br />
    /// Using <c>halt</c> (or <c>void</c>/<c>nothing</c>, which is the same)
    /// for method output means that the methos doesn't return normally.<br /><c>canbenull</c> annotation is only applicable for output parameters.<br />
    /// You can use multiple <c>[ContractAnnotation]</c> for each FDT row,
    /// or use single attribute with rows separated by semicolon.<br /></syntax>
    /// <examples>
    ///   <list>
    ///     <item>
    ///       <code>
    /// [ContractAnnotation("=&gt; halt")]
    /// public void TerminationMethod()
    /// </code>
    ///     </item>
    ///     <item>
    ///       <code>
    /// [ContractAnnotation("halt &lt;= condition: false")]
    /// public void Assert(bool condition, string text) // regular assertion method
    /// </code>
    ///     </item>
    ///     <item>
    ///       <code>
    /// [ContractAnnotation("s:null =&gt; true")]
    /// public bool IsNullOrEmpty(string s) // string.IsNullOrEmpty()
    /// </code>
    ///     </item>
    ///     <item>
    ///       <code>
    /// // A method that returns null if the parameter is null, and not null if the parameter is not null
    /// [ContractAnnotation("null =&gt; null; notnull =&gt; notnull")]
    /// public object Transform(object data)
    /// </code>
    ///     </item>
    ///     <item>
    ///       <code>
    /// [ContractAnnotation("s:null=&gt;false; =&gt;true,result:notnull; =&gt;false, result:null")]
    /// public bool TryParse(string s, out Person result)
    /// </code>
    ///     </item>
    ///   </list>
    /// </examples>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
  internal sealed class ContractAnnotationAttribute : Attribute
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContractAnnotationAttribute"/> class.
        /// </summary>
        /// <param name="contract">The contract.</param>
        public ContractAnnotationAttribute([NotNull] string contract)
      : this(contract, false) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContractAnnotationAttribute"/> class.
        /// </summary>
        /// <param name="contract">The contract.</param>
        /// <param name="forceFullStates">if set to <c>true</c> [force full states].</param>
        public ContractAnnotationAttribute([NotNull] string contract, bool forceFullStates)
    {
      Contract = contract;
      ForceFullStates = forceFullStates;
    }

        /// <summary>
        /// Gets the contract.
        /// </summary>
        /// <value>The contract.</value>
        public string Contract { get; private set; }
        /// <summary>
        /// Gets a value indicating whether [force full states].
        /// </summary>
        /// <value><c>true</c> if [force full states]; otherwise, <c>false</c>.</value>
        public bool ForceFullStates { get; private set; }
  }

    /// <summary>
    /// Indicates that marked element should be localized or not
    /// </summary>
    /// <seealso cref="System.Attribute" />
    /// <example>
    ///   <code>
    /// [LocalizationRequiredAttribute(true)]
    /// public class Foo {
    /// private string str = "my string"; // Warning: Localizable string
    /// }
    /// </code>
    /// </example>
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
  internal sealed class LocalizationRequiredAttribute : Attribute
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocalizationRequiredAttribute"/> class.
        /// </summary>
        public LocalizationRequiredAttribute() : this(true) { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LocalizationRequiredAttribute"/> class.
        /// </summary>
        /// <param name="required">if set to <c>true</c> [required].</param>
        public LocalizationRequiredAttribute(bool required)
    {
      Required = required;
    }

        /// <summary>
        /// Gets a value indicating whether this <see cref="LocalizationRequiredAttribute"/> is required.
        /// </summary>
        /// <value><c>true</c> if required; otherwise, <c>false</c>.</value>
        public bool Required { get; private set; }
  }

    /// <summary>
    /// Indicates that the value of the marked type (or its derivatives)
    /// cannot be compared using '==' or '!=' operators and <c>Equals()</c>
    /// should be used instead. However, using '==' or '!=' for comparison
    /// with <c>null</c> is always permitted.
    /// </summary>
    /// <seealso cref="System.Attribute" />
    /// <example>
    ///   <code>
    /// [CannotApplyEqualityOperator]
    /// class NoEquality { }
    /// class UsesNoEquality {
    /// public void Test() {
    /// var ca1 = new NoEquality();
    /// var ca2 = new NoEquality();
    /// if (ca1 != null) { // OK
    /// bool condition = ca1 == ca2; // Warning
    /// }
    /// }
    /// }
    /// </code>
    /// </example>
    [AttributeUsage(
    AttributeTargets.Interface | AttributeTargets.Class |
    AttributeTargets.Struct, AllowMultiple = false, Inherited = true)]
  internal sealed class CannotApplyEqualityOperatorAttribute : Attribute { }

    /// <summary>
    /// When applied to a target attribute, specifies a requirement for any type marked
    /// with the target attribute to implement or inherit specific type or types.
    /// </summary>
    /// <seealso cref="System.Attribute" />
    /// <example>
    ///   <code>
    /// [BaseTypeRequired(typeof(IComponent)] // Specify requirement
    /// public class ComponentAttribute : Attribute { }
    /// [Component] // ComponentAttribute requires implementing IComponent interface
    /// public class MyComponent : IComponent { }
    /// </code>
    /// </example>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
  [BaseTypeRequired(typeof(Attribute))]
  internal sealed class BaseTypeRequiredAttribute : Attribute
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseTypeRequiredAttribute"/> class.
        /// </summary>
        /// <param name="baseType">Type of the base.</param>
        public BaseTypeRequiredAttribute([NotNull] Type baseType)
    {
      BaseType = baseType;
    }

        /// <summary>
        /// Gets the type of the base.
        /// </summary>
        /// <value>The type of the base.</value>
        [NotNull] public Type BaseType { get; private set; }
  }

    /// <summary>
    /// Indicates that the marked symbol is used implicitly
    /// (e.g. via reflection, in external library), so this symbol
    /// will not be marked as unused (as well as by other usage inspections)
    /// </summary>
    /// <seealso cref="System.Attribute" />
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
  internal sealed class UsedImplicitlyAttribute : Attribute
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsedImplicitlyAttribute"/> class.
        /// </summary>
        public UsedImplicitlyAttribute()
      : this(ImplicitUseKindFlags.Default, ImplicitUseTargetFlags.Default) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsedImplicitlyAttribute"/> class.
        /// </summary>
        /// <param name="useKindFlags">The use kind flags.</param>
        public UsedImplicitlyAttribute(ImplicitUseKindFlags useKindFlags)
      : this(useKindFlags, ImplicitUseTargetFlags.Default) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsedImplicitlyAttribute"/> class.
        /// </summary>
        /// <param name="targetFlags">The target flags.</param>
        public UsedImplicitlyAttribute(ImplicitUseTargetFlags targetFlags)
      : this(ImplicitUseKindFlags.Default, targetFlags) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsedImplicitlyAttribute"/> class.
        /// </summary>
        /// <param name="useKindFlags">The use kind flags.</param>
        /// <param name="targetFlags">The target flags.</param>
        public UsedImplicitlyAttribute(
      ImplicitUseKindFlags useKindFlags, ImplicitUseTargetFlags targetFlags)
    {
      UseKindFlags = useKindFlags;
      TargetFlags = targetFlags;
    }

        /// <summary>
        /// Gets the use kind flags.
        /// </summary>
        /// <value>The use kind flags.</value>
        public ImplicitUseKindFlags UseKindFlags { get; private set; }
        /// <summary>
        /// Gets the target flags.
        /// </summary>
        /// <value>The target flags.</value>
        public ImplicitUseTargetFlags TargetFlags { get; private set; }
  }

    /// <summary>
    /// Should be used on attributes and causes ReSharper
    /// to not mark symbols marked with such attributes as unused
    /// (as well as by other usage inspections)
    /// </summary>
    /// <seealso cref="System.Attribute" />
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
  internal sealed class MeansImplicitUseAttribute : Attribute
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="MeansImplicitUseAttribute"/> class.
        /// </summary>
        public MeansImplicitUseAttribute() 
      : this(ImplicitUseKindFlags.Default, ImplicitUseTargetFlags.Default) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="MeansImplicitUseAttribute"/> class.
        /// </summary>
        /// <param name="useKindFlags">The use kind flags.</param>
        public MeansImplicitUseAttribute(ImplicitUseKindFlags useKindFlags)
      : this(useKindFlags, ImplicitUseTargetFlags.Default) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="MeansImplicitUseAttribute"/> class.
        /// </summary>
        /// <param name="targetFlags">The target flags.</param>
        public MeansImplicitUseAttribute(ImplicitUseTargetFlags targetFlags)
      : this(ImplicitUseKindFlags.Default, targetFlags) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="MeansImplicitUseAttribute"/> class.
        /// </summary>
        /// <param name="useKindFlags">The use kind flags.</param>
        /// <param name="targetFlags">The target flags.</param>
        public MeansImplicitUseAttribute(
      ImplicitUseKindFlags useKindFlags, ImplicitUseTargetFlags targetFlags)
    {
      UseKindFlags = useKindFlags;
      TargetFlags = targetFlags;
    }

        /// <summary>
        /// Gets the use kind flags.
        /// </summary>
        /// <value>The use kind flags.</value>
        [UsedImplicitly] public ImplicitUseKindFlags UseKindFlags { get; private set; }
        /// <summary>
        /// Gets the target flags.
        /// </summary>
        /// <value>The target flags.</value>
        [UsedImplicitly] public ImplicitUseTargetFlags TargetFlags { get; private set; }
  }

    /// <summary>
    /// Enum ImplicitUseKindFlags
    /// </summary>
    [Flags]
  internal enum ImplicitUseKindFlags
  {
        /// <summary>
        /// The default
        /// </summary>
        Default = Access | Assign | InstantiatedWithFixedConstructorSignature,
        /// <summary>
        /// Only entity marked with attribute considered used
        /// </summary>
        Access = 1,
        /// <summary>
        /// Indicates implicit assignment to a member
        /// </summary>
        Assign = 2,
        /// <summary>
        /// Indicates implicit instantiation of a type with fixed constructor signature.
        /// That means any unused constructor parameters won't be reported as such.
        /// </summary>
        InstantiatedWithFixedConstructorSignature = 4,
        /// <summary>
        /// Indicates implicit instantiation of a type
        /// </summary>
        InstantiatedNoFixedConstructorSignature = 8,
  }

    /// <summary>
    /// Specify what is considered used implicitly
    /// when marked with <see cref="MeansImplicitUseAttribute" />
    /// or <see cref="UsedImplicitlyAttribute" />
    /// </summary>
    [Flags]
  internal enum ImplicitUseTargetFlags
  {
        /// <summary>
        /// The default
        /// </summary>
        Default = Itself,
        /// <summary>
        /// The itself
        /// </summary>
        Itself = 1,
        /// <summary>
        /// Members of entity marked with attribute are considered used
        /// </summary>
        Members = 2,
        /// <summary>
        /// Entity marked with attribute and all its members considered used
        /// </summary>
        WithMembers = Itself | Members
  }

    /// <summary>
    /// This attribute is intended to mark publicly available API
    /// which should not be removed and so is treated as used
    /// </summary>
    /// <seealso cref="System.Attribute" />
    [MeansImplicitUse]
  internal sealed class PublicAPIAttribute : Attribute
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAPIAttribute"/> class.
        /// </summary>
        public PublicAPIAttribute() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAPIAttribute"/> class.
        /// </summary>
        /// <param name="comment">The comment.</param>
        public PublicAPIAttribute([NotNull] string comment)
    {
      Comment = comment;
    }

        /// <summary>
        /// Gets the comment.
        /// </summary>
        /// <value>The comment.</value>
        [NotNull] public string Comment { get; private set; }
  }

    /// <summary>
    /// Tells code analysis engine if the parameter is completely handled
    /// when the invoked method is on stack. If the parameter is a delegate,
    /// indicates that delegate is executed while the method is executed.
    /// If the parameter is an enumerable, indicates that it is enumerated
    /// while the method is executed
    /// </summary>
    /// <seealso cref="System.Attribute" />
    [AttributeUsage(AttributeTargets.Parameter, Inherited = true)]
  internal sealed class InstantHandleAttribute : Attribute { }

    /// <summary>
    /// Indicates that a method does not make any observable state changes.
    /// The same as <c>System.Diagnostics.Contracts.PureAttribute</c>
    /// </summary>
    /// <seealso cref="System.Attribute" />
    /// <example>
    ///   <code>
    /// [Pure] private int Multiply(int x, int y) { return x * y; }
    /// public void Foo() {
    /// const int a = 2, b = 2;
    /// Multiply(a, b); // Waring: Return value of pure method is not used
    /// }
    /// </code>
    /// </example>
    [AttributeUsage(AttributeTargets.Method, Inherited = true)]
  internal sealed class PureAttribute : Attribute { }

    /// <summary>
    /// Indicates that a parameter is a path to a file or a folder
    /// within a web project. Path can be relative or absolute,
    /// starting from web root (~)
    /// </summary>
    /// <seealso cref="System.Attribute" />
    [AttributeUsage(AttributeTargets.Parameter)]
  internal class PathReferenceAttribute : Attribute
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PathReferenceAttribute"/> class.
        /// </summary>
        public PathReferenceAttribute() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PathReferenceAttribute"/> class.
        /// </summary>
        /// <param name="basePath">The base path.</param>
        public PathReferenceAttribute([PathReference] string basePath)
    {
      BasePath = basePath;
    }

        /// <summary>
        /// Gets the base path.
        /// </summary>
        /// <value>The base path.</value>
        [NotNull] public string BasePath { get; private set; }
  }

    // ASP.NET MVC attributes

    /// <summary>
    /// Class AspMvcAreaMasterLocationFormatAttribute. This class cannot be inherited.
    /// </summary>
    /// <seealso cref="System.Attribute" />
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
  internal sealed class AspMvcAreaMasterLocationFormatAttribute : Attribute
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="AspMvcAreaMasterLocationFormatAttribute"/> class.
        /// </summary>
        /// <param name="format">The format.</param>
        public AspMvcAreaMasterLocationFormatAttribute(string format) { }
  }

    /// <summary>
    /// Class AspMvcAreaPartialViewLocationFormatAttribute. This class cannot be inherited.
    /// </summary>
    /// <seealso cref="System.Attribute" />
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
  internal sealed class AspMvcAreaPartialViewLocationFormatAttribute : Attribute
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="AspMvcAreaPartialViewLocationFormatAttribute"/> class.
        /// </summary>
        /// <param name="format">The format.</param>
        public AspMvcAreaPartialViewLocationFormatAttribute(string format) { }
  }

    /// <summary>
    /// Class AspMvcAreaViewLocationFormatAttribute. This class cannot be inherited.
    /// </summary>
    /// <seealso cref="System.Attribute" />
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
  internal sealed class AspMvcAreaViewLocationFormatAttribute : Attribute
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="AspMvcAreaViewLocationFormatAttribute"/> class.
        /// </summary>
        /// <param name="format">The format.</param>
        public AspMvcAreaViewLocationFormatAttribute(string format) { }
  }

    /// <summary>
    /// Class AspMvcMasterLocationFormatAttribute. This class cannot be inherited.
    /// </summary>
    /// <seealso cref="System.Attribute" />
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
  internal sealed class AspMvcMasterLocationFormatAttribute : Attribute
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="AspMvcMasterLocationFormatAttribute"/> class.
        /// </summary>
        /// <param name="format">The format.</param>
        public AspMvcMasterLocationFormatAttribute(string format) { }
  }

    /// <summary>
    /// Class AspMvcPartialViewLocationFormatAttribute. This class cannot be inherited.
    /// </summary>
    /// <seealso cref="System.Attribute" />
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
  internal sealed class AspMvcPartialViewLocationFormatAttribute : Attribute
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="AspMvcPartialViewLocationFormatAttribute"/> class.
        /// </summary>
        /// <param name="format">The format.</param>
        public AspMvcPartialViewLocationFormatAttribute(string format) { }
  }

    /// <summary>
    /// Class AspMvcViewLocationFormatAttribute. This class cannot be inherited.
    /// </summary>
    /// <seealso cref="System.Attribute" />
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
  internal sealed class AspMvcViewLocationFormatAttribute : Attribute
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="AspMvcViewLocationFormatAttribute"/> class.
        /// </summary>
        /// <param name="format">The format.</param>
        public AspMvcViewLocationFormatAttribute(string format) { }
  }

    /// <summary>
    /// ASP.NET MVC attribute. If applied to a parameter, indicates that the parameter
    /// is an MVC action. If applied to a method, the MVC action name is calculated
    /// implicitly from the context. Use this attribute for custom wrappers similar to
    /// <c>System.Web.Mvc.Html.ChildActionExtensions.RenderAction(HtmlHelper, String)</c>
    /// </summary>
    /// <seealso cref="System.Attribute" />
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Method)]
  internal sealed class AspMvcActionAttribute : Attribute
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="AspMvcActionAttribute"/> class.
        /// </summary>
        public AspMvcActionAttribute() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AspMvcActionAttribute"/> class.
        /// </summary>
        /// <param name="anonymousProperty">The anonymous property.</param>
        public AspMvcActionAttribute([NotNull] string anonymousProperty)
    {
      AnonymousProperty = anonymousProperty;
    }

        /// <summary>
        /// Gets the anonymous property.
        /// </summary>
        /// <value>The anonymous property.</value>
        [NotNull] public string AnonymousProperty { get; private set; }
  }

    /// <summary>
    /// ASP.NET MVC attribute. Indicates that a parameter is an MVC area.
    /// Use this attribute for custom wrappers similar to
    /// <c>System.Web.Mvc.Html.ChildActionExtensions.RenderAction(HtmlHelper, String)</c>
    /// </summary>
    /// <seealso cref="Zeroit.Framework.Transitions.Betwixt.Annotations.PathReferenceAttribute" />
    [AttributeUsage(AttributeTargets.Parameter)]
  internal sealed class AspMvcAreaAttribute : PathReferenceAttribute
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="AspMvcAreaAttribute"/> class.
        /// </summary>
        public AspMvcAreaAttribute() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AspMvcAreaAttribute"/> class.
        /// </summary>
        /// <param name="anonymousProperty">The anonymous property.</param>
        public AspMvcAreaAttribute([NotNull] string anonymousProperty)
    {
      AnonymousProperty = anonymousProperty;
    }

        /// <summary>
        /// Gets the anonymous property.
        /// </summary>
        /// <value>The anonymous property.</value>
        [NotNull] public string AnonymousProperty { get; private set; }
  }

    /// <summary>
    /// ASP.NET MVC attribute. If applied to a parameter, indicates that
    /// the parameter is an MVC controller. If applied to a method,
    /// the MVC controller name is calculated implicitly from the context.
    /// Use this attribute for custom wrappers similar to
    /// <c>System.Web.Mvc.Html.ChildActionExtensions.RenderAction(HtmlHelper, String, String)</c>
    /// </summary>
    /// <seealso cref="System.Attribute" />
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Method)]
  internal sealed class AspMvcControllerAttribute : Attribute
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="AspMvcControllerAttribute"/> class.
        /// </summary>
        public AspMvcControllerAttribute() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AspMvcControllerAttribute"/> class.
        /// </summary>
        /// <param name="anonymousProperty">The anonymous property.</param>
        public AspMvcControllerAttribute([NotNull] string anonymousProperty)
    {
      AnonymousProperty = anonymousProperty;
    }

        /// <summary>
        /// Gets the anonymous property.
        /// </summary>
        /// <value>The anonymous property.</value>
        [NotNull] public string AnonymousProperty { get; private set; }
  }

    /// <summary>
    /// ASP.NET MVC attribute. Indicates that a parameter is an MVC Master.
    /// Use this attribute for custom wrappers similar to
    /// <c>System.Web.Mvc.Controller.View(String, String)</c>
    /// </summary>
    /// <seealso cref="System.Attribute" />
    [AttributeUsage(AttributeTargets.Parameter)]
  internal sealed class AspMvcMasterAttribute : Attribute { }

    /// <summary>
    /// ASP.NET MVC attribute. Indicates that a parameter is an MVC model type.
    /// Use this attribute for custom wrappers similar to
    /// <c>System.Web.Mvc.Controller.View(String, Object)</c>
    /// </summary>
    /// <seealso cref="System.Attribute" />
    [AttributeUsage(AttributeTargets.Parameter)]
  internal sealed class AspMvcModelTypeAttribute : Attribute { }

    /// <summary>
    /// ASP.NET MVC attribute. If applied to a parameter, indicates that
    /// the parameter is an MVC partial view. If applied to a method,
    /// the MVC partial view name is calculated implicitly from the context.
    /// Use this attribute for custom wrappers similar to
    /// <c>System.Web.Mvc.Html.RenderPartialExtensions.RenderPartial(HtmlHelper, String)</c>
    /// </summary>
    /// <seealso cref="Zeroit.Framework.Transitions.Betwixt.Annotations.PathReferenceAttribute" />
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Method)]
  internal sealed class AspMvcPartialViewAttribute : PathReferenceAttribute { }

    /// <summary>
    /// ASP.NET MVC attribute. Allows disabling all inspections
    /// for MVC views within a class or a method.
    /// </summary>
    /// <seealso cref="System.Attribute" />
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
  internal sealed class AspMvcSupressViewErrorAttribute : Attribute { }

    /// <summary>
    /// ASP.NET MVC attribute. Indicates that a parameter is an MVC display template.
    /// Use this attribute for custom wrappers similar to
    /// <c>System.Web.Mvc.Html.DisplayExtensions.DisplayForModel(HtmlHelper, String)</c>
    /// </summary>
    /// <seealso cref="System.Attribute" />
    [AttributeUsage(AttributeTargets.Parameter)]
  internal sealed class AspMvcDisplayTemplateAttribute : Attribute { }

    /// <summary>
    /// ASP.NET MVC attribute. Indicates that a parameter is an MVC editor template.
    /// Use this attribute for custom wrappers similar to
    /// <c>System.Web.Mvc.Html.EditorExtensions.EditorForModel(HtmlHelper, String)</c>
    /// </summary>
    /// <seealso cref="System.Attribute" />
    [AttributeUsage(AttributeTargets.Parameter)]
  internal sealed class AspMvcEditorTemplateAttribute : Attribute { }

    /// <summary>
    /// ASP.NET MVC attribute. Indicates that a parameter is an MVC template.
    /// Use this attribute for custom wrappers similar to
    /// <c>System.ComponentModel.DataAnnotations.UIHintAttribute(System.String)</c>
    /// </summary>
    /// <seealso cref="System.Attribute" />
    [AttributeUsage(AttributeTargets.Parameter)]
  internal sealed class AspMvcTemplateAttribute : Attribute { }

    /// <summary>
    /// ASP.NET MVC attribute. If applied to a parameter, indicates that the parameter
    /// is an MVC view. If applied to a method, the MVC view name is calculated implicitly
    /// from the context. Use this attribute for custom wrappers similar to
    /// <c>System.Web.Mvc.Controller.View(Object)</c>
    /// </summary>
    /// <seealso cref="Zeroit.Framework.Transitions.Betwixt.Annotations.PathReferenceAttribute" />
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Method)]
  internal sealed class AspMvcViewAttribute : PathReferenceAttribute { }

    /// <summary>
    /// ASP.NET MVC attribute. When applied to a parameter of an attribute,
    /// indicates that this parameter is an MVC action name
    /// </summary>
    /// <seealso cref="System.Attribute" />
    /// <example>
    ///   <code>
    /// [ActionName("Foo")]
    /// public ActionResult Login(string returnUrl) {
    /// ViewBag.ReturnUrl = Url.Action("Foo"); // OK
    /// return RedirectToAction("Bar"); // Error: Cannot resolve action
    /// }
    /// </code>
    /// </example>
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Property)]
  internal sealed class AspMvcActionSelectorAttribute : Attribute { }

    /// <summary>
    /// Class HtmlElementAttributesAttribute. This class cannot be inherited.
    /// </summary>
    /// <seealso cref="System.Attribute" />
    [AttributeUsage(
    AttributeTargets.Parameter | AttributeTargets.Property |
    AttributeTargets.Field, Inherited = true)]
  internal sealed class HtmlElementAttributesAttribute : Attribute
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlElementAttributesAttribute"/> class.
        /// </summary>
        public HtmlElementAttributesAttribute() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlElementAttributesAttribute"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        public HtmlElementAttributesAttribute([NotNull] string name)
    {
      Name = name;
    }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        [NotNull] public string Name { get; private set; }
  }

    /// <summary>
    /// Class HtmlAttributeValueAttribute. This class cannot be inherited.
    /// </summary>
    /// <seealso cref="System.Attribute" />
    [AttributeUsage(
    AttributeTargets.Parameter | AttributeTargets.Field |
    AttributeTargets.Property, Inherited = true)]
  internal sealed class HtmlAttributeValueAttribute : Attribute
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlAttributeValueAttribute"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        public HtmlAttributeValueAttribute([NotNull] string name)
    {
      Name = name;
    }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        [NotNull] public string Name { get; private set; }
  }

    // Razor attributes

    /// <summary>
    /// Razor attribute. Indicates that a parameter or a method is a Razor section.
    /// Use this attribute for custom wrappers similar to
    /// <c>System.Web.WebPages.WebPageBase.RenderSection(String)</c>
    /// </summary>
    /// <seealso cref="System.Attribute" />
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Method, Inherited = true)]
  internal sealed class RazorSectionAttribute : Attribute { }
}
namespace SolvingProblems.BasicCSharp.NewOverrideExample
{
    public enum MethodType
    {
        Base,
        Derived,
        Overrided
    }

    /// <summary>
    /// Examples for better understanding new/override keywords
    /// https://docs.microsoft.com/ru-ru/dotnet/csharp/programming-guide/classes-and-structs/knowing-when-to-use-override-and-new-keywords
    /// </summary>
    public class BaseClass
    {
        public MethodType BaseMethod()
        {
            return MethodType.Base;
        }

        public MethodType BothMethod()
        {
            return MethodType.Base;
        }

        public virtual MethodType OverridedMethod()
        {
            return MethodType.Base;
        }
    }

    public class DerivedClass : BaseClass
    {
        public MethodType DerivedMethod()
        {
            return MethodType.Derived;
        }

        public new MethodType BothMethod()
        {
            return MethodType.Derived;
        }

        public override MethodType OverridedMethod()
        {
            return MethodType.Overrided;
        }
    }
}
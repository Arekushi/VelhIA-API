//using PostSharp.Aspects;
//using System;
//using System.Threading.Tasks;

//namespace VelhIA_API.API.Attributes
//{
//    [Serializable]
//    public class IgnoreMethodAttribute : MethodInterceptionAspect
//    {
//        public bool IsIgnored { get; set; }

//        public override Task OnInvokeAsync(MethodInterceptionArgs args)
//        {
//            return base.OnInvokeAsync(args);
//        }

//        public override void OnInvoke(MethodInterceptionArgs args)
//        {
//            //if (IsIgnored)
//            //{
//            //    return;
//            //}

//            base.OnInvoke(args);
//        }
//    }
//}

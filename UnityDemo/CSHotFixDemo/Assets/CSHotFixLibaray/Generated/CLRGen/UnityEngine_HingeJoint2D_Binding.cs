using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

using CSHotFix.CLR.TypeSystem;
using CSHotFix.CLR.Method;
using CSHotFix.Runtime.Enviorment;
using CSHotFix.Runtime.Intepreter;
using CSHotFix.Runtime.Stack;
using CSHotFix.Reflection;
using CSHotFix.CLR.Utils;

namespace CSHotFix.Runtime.Generated
{
    unsafe class UnityEngine_HingeJoint2D_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.HingeJoint2D);
            args = new Type[]{};
            method = type.GetMethod("get_useMotor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_useMotor_0);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_useMotor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_useMotor_1);
            args = new Type[]{};
            method = type.GetMethod("get_useLimits", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_useLimits_2);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_useLimits", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_useLimits_3);
            args = new Type[]{};
            method = type.GetMethod("get_motor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_motor_4);
            args = new Type[]{typeof(UnityEngine.JointMotor2D)};
            method = type.GetMethod("set_motor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_motor_5);
            args = new Type[]{};
            method = type.GetMethod("get_limits", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_limits_6);
            args = new Type[]{typeof(UnityEngine.JointAngleLimits2D)};
            method = type.GetMethod("set_limits", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_limits_7);
            args = new Type[]{};
            method = type.GetMethod("get_limitState", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_limitState_8);
            args = new Type[]{};
            method = type.GetMethod("get_referenceAngle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_referenceAngle_9);
            args = new Type[]{};
            method = type.GetMethod("get_jointAngle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_jointAngle_10);
            args = new Type[]{};
            method = type.GetMethod("get_jointSpeed", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_jointSpeed_11);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("GetMotorTorque", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetMotorTorque_12);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.HingeJoint2D());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.HingeJoint2D[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_useMotor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.HingeJoint2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.HingeJoint2D)typeof(UnityEngine.HingeJoint2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.useMotor;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_useMotor_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.HingeJoint2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.HingeJoint2D)typeof(UnityEngine.HingeJoint2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.useMotor = value;

            return __ret;
        }

        static StackObject* get_useLimits_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.HingeJoint2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.HingeJoint2D)typeof(UnityEngine.HingeJoint2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.useLimits;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_useLimits_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.HingeJoint2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.HingeJoint2D)typeof(UnityEngine.HingeJoint2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.useLimits = value;

            return __ret;
        }

        static StackObject* get_motor_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.HingeJoint2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.HingeJoint2D)typeof(UnityEngine.HingeJoint2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.motor;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_motor_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.JointMotor2D value = (UnityEngine.JointMotor2D)typeof(UnityEngine.JointMotor2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.HingeJoint2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.HingeJoint2D)typeof(UnityEngine.HingeJoint2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.motor = value;

            return __ret;
        }

        static StackObject* get_limits_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.HingeJoint2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.HingeJoint2D)typeof(UnityEngine.HingeJoint2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.limits;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_limits_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.JointAngleLimits2D value = (UnityEngine.JointAngleLimits2D)typeof(UnityEngine.JointAngleLimits2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.HingeJoint2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.HingeJoint2D)typeof(UnityEngine.HingeJoint2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.limits = value;

            return __ret;
        }

        static StackObject* get_limitState_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.HingeJoint2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.HingeJoint2D)typeof(UnityEngine.HingeJoint2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.limitState;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_referenceAngle_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.HingeJoint2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.HingeJoint2D)typeof(UnityEngine.HingeJoint2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.referenceAngle;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_jointAngle_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.HingeJoint2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.HingeJoint2D)typeof(UnityEngine.HingeJoint2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.jointAngle;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_jointSpeed_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.HingeJoint2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.HingeJoint2D)typeof(UnityEngine.HingeJoint2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.jointSpeed;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetMotorTorque_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single timeStep = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.HingeJoint2D instance_of_this_method;
            instance_of_this_method = (UnityEngine.HingeJoint2D)typeof(UnityEngine.HingeJoint2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetMotorTorque(timeStep);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.HingeJoint2D();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

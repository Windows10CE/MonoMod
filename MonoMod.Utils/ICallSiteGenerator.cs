using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Linq.Expressions;
using MonoMod.Utils;
using System.Collections.Generic;
using Mono.Cecil;
using Mono.Cecil.Cil;
using System.Linq;
using System.Runtime.InteropServices;
using System.IO;

namespace MonoMod.Utils {
    public interface ICallSiteGenerator {

        CallSite ToCallSite(ModuleDefinition module);

    }
}

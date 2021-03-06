﻿using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.Windsor.Installer;
using System;
using System.IO;

namespace TorbaliBurada.Core
{
    public class DependencyContainer
    {
        //Castle.Windsor.3.3.0 eklendi
        public static IWindsorContainer WindsorContainer { get; private set; }
        public static FromAssemblyDescriptor Descriptor { get; private set; }
        private static bool bootstrapped;
        public static void Bootstrap()
        {
            if (!bootstrapped)
            {
                WindsorContainer = new WindsorContainer();
                var assemblFilter = new AssemblyFilter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bin"));
                Descriptor = Classes.FromAssemblyInDirectory(assemblFilter);
                WindsorContainer.Install(FromAssembly.InDirectory(assemblFilter));
                bootstrapped = true;
            }
        }
        public static  T Resolve<T>()
            {
            return WindsorContainer.Resolve<T>();
            }

        public static object Resolve(Type type)
        {
            return WindsorContainer.Resolve(type);
        }
    }
}

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Unity;
using Unity.Resolution;

namespace Boss.DDD
{
    public class ServiceLocator : IServiceProvider
    {
        private readonly IUnityContainer _unityContainer;

        public ServiceLocator()
        {
            _unityContainer = new UnityContainer();
            var jsonservice = JObject.Parse(File.ReadAllText("appsettings.json"))["DIService"];
            var requestservers = JsonConvert.DeserializeObject<List<DIService>>(jsonservice.ToString());
            foreach (var item in requestservers)
            {
                _unityContainer.RegisterType(Type.GetType(item.InterfaceType), Type.GetType(item.ImplActionType));
            }
        }

        public T GetService<T>()
        {
            return _unityContainer.Resolve<T>();
        }

        public object GetService(Type serviceType)
        {
            return _unityContainer.Resolve(serviceType);
        }

        public T GetService<T>(ParameterOverrides parameterOverrides)
        {
            return _unityContainer.Resolve<T>(parameterOverrides);
        }
    }
}
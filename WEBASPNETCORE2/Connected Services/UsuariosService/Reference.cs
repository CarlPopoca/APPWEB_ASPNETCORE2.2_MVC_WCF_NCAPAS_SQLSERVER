﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UsuariosService
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UsuariosService.IUsuariosService")]
    public interface IUsuariosService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuariosService/ObtenerUsuarios", ReplyAction="http://tempuri.org/IUsuariosService/ObtenerUsuariosResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<WebPruebaEntities.Usuarios>> ObtenerUsuariosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuariosService/CrearUsuarios", ReplyAction="http://tempuri.org/IUsuariosService/CrearUsuariosResponse")]
        System.Threading.Tasks.Task<WebPruebaEntities.Usuarios> CrearUsuariosAsync(WebPruebaEntities.Usuarios entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuariosService/ActualizarUsuarios", ReplyAction="http://tempuri.org/IUsuariosService/ActualizarUsuariosResponse")]
        System.Threading.Tasks.Task<bool> ActualizarUsuariosAsync(WebPruebaEntities.Usuarios enitity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuariosService/EliminarUsuarios", ReplyAction="http://tempuri.org/IUsuariosService/EliminarUsuariosResponse")]
        System.Threading.Tasks.Task<bool> EliminarUsuariosAsync(int usuarioId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuariosService/ObtenerUsuarioById", ReplyAction="http://tempuri.org/IUsuariosService/ObtenerUsuarioByIdResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<WebPruebaEntities.Usuarios>> ObtenerUsuarioByIdAsync(int usuarioId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    public interface IUsuariosServiceChannel : UsuariosService.IUsuariosService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    public partial class UsuariosServiceClient : System.ServiceModel.ClientBase<UsuariosService.IUsuariosService>, UsuariosService.IUsuariosService
    {
        
        /// <summary>
        /// Implemente este método parcial para configurar el punto de conexión de servicio.
        /// </summary>
        /// <param name="serviceEndpoint">El punto de conexión para configurar</param>
        /// <param name="clientCredentials">Credenciales de cliente</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public UsuariosServiceClient() : 
                base(UsuariosServiceClient.GetDefaultBinding(), UsuariosServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IUsuariosService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UsuariosServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(UsuariosServiceClient.GetBindingForEndpoint(endpointConfiguration), UsuariosServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UsuariosServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(UsuariosServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UsuariosServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(UsuariosServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UsuariosServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<WebPruebaEntities.Usuarios>> ObtenerUsuariosAsync()
        {
            return base.Channel.ObtenerUsuariosAsync();
        }
        
        public System.Threading.Tasks.Task<WebPruebaEntities.Usuarios> CrearUsuariosAsync(WebPruebaEntities.Usuarios entity)
        {
            return base.Channel.CrearUsuariosAsync(entity);
        }
        
        public System.Threading.Tasks.Task<bool> ActualizarUsuariosAsync(WebPruebaEntities.Usuarios enitity)
        {
            return base.Channel.ActualizarUsuariosAsync(enitity);
        }
        
        public System.Threading.Tasks.Task<bool> EliminarUsuariosAsync(int usuarioId)
        {
            return base.Channel.EliminarUsuariosAsync(usuarioId);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<WebPruebaEntities.Usuarios>> ObtenerUsuarioByIdAsync(int usuarioId)
        {
            return base.Channel.ObtenerUsuarioByIdAsync(usuarioId);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IUsuariosService))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IUsuariosService))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:50557/UsuariosService.svc");
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return UsuariosServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IUsuariosService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return UsuariosServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IUsuariosService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IUsuariosService,
        }
    }
}

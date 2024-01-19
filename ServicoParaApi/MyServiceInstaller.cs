using System;
using System.ComponentModel;
using System.Configuration.Install;
using System.ServiceProcess;

[RunInstaller(true)]
public class MyServiceInstaller : Installer
{
    private ServiceProcessInstaller processInstaller;
    private ServiceInstaller serviceInstaller;

    public MyServiceInstaller()
    {
        // Configurar o instalador do processo do serviço
        processInstaller = new ServiceProcessInstaller();
        processInstaller.Account = ServiceAccount.LocalSystem;

        // Configurar o instalador do serviço
        serviceInstaller = new ServiceInstaller();
        serviceInstaller.StartType = ServiceStartMode.Automatic;
        serviceInstaller.ServiceName = "ServicoApi";
        serviceInstaller.Description = "Serviço de chamada de API";

        // Adicionar instaladores ao instalador principal
        Installers.Add(processInstaller);
        Installers.Add(serviceInstaller);
    }
}

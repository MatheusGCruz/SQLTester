Add the following template as the App.config (saves the most used configs)

<?xml version="1.0" encoding="utf-8" ?>
<configuration>
    <startup> 
        <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.8" />
    </startup>
  <appSettings>
    <add key="Server" value=""/>
    <add key="Database" value=""/>
    <add key="UserName" value=""/>
    <add key="Password" value=""/>

    <add key="BaseFile" value=""/>
    <add key="PrototypeFile" value=""/>
    <add key="ReportLocation" value=""/>
  </appSettings>
</configuration>

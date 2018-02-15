HtmlProvider works so I think I applied the workaround from this link correctly: https://github.com/Microsoft/visualfsharp/issues/3303#issuecomment-312966306.

![html provider builds and runs successfully](https://user-images.githubusercontent.com/2267030/36234647-1e15f670-11ba-11e8-9f53-28d93e5e529c.png)

WsdlService does not build. I guess that means the WsdlService source code needs to be updated?

error FS2024: Static linking may not be used on an assembly referencing mscorlib (e.g. a .NET Framework assembly) when generating an assembly that references System.Runtime (e.g. a .NET Core or Portable assembly). [C:\git\personal\tp-apps\tpapp-wsdl\tpapp-wsdl.fsproj]

![wsdl service provider does not build because FS2024 static linking may not be used on an assembly referencing mscorlib](https://user-images.githubusercontent.com/2267030/36234672-5175ccc0-11ba-11e8-9e33-b48c4e3aa610.png)
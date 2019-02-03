# Trying to get to the bottom of a project setup problem

When trying to use the new nuget based Xenko setup I always run into exceptions.  
In order to find out what exactly is the issue and hopefully resolve it I created this repo.  

Error	5,241s	[AssetCompiler] Unhandled exception.  
  Exception: Unable to load one or more of the requested types.  
  Retrieve the LoaderExceptions property for more information.  

MyGame.Windows	H:\Tests\XenkoBuildRepro\MyGame.Windows\EXEC	1	 
Error	MSB3073	The command  
  ""C:\Users\boris\.nuget\packages\xenko.core.assets.compilerapp\3.1.0.1-beta01-0430\build\..\lib\net472\Xenko.Core.Assets.CompilerApp.exe"  
  --disable-auto-compile  
  --project-configuration "Debug"  
  --platform=Windows  
  --project-configuration=Debug  
  --property:RuntimeIdentifier=win7-x86  
  --output-path="H:\Tests\XenkoBuildRepro\Bin\Windows\Debug\data"  
  --build-path="H:\Tests\XenkoBuildRepro\MyGame.Windows\obj\xenko\assetbuild\data"  
  --package-file="H:\Tests\XenkoBuildRepro\MyGame.Windows\MyGame.Windows.csproj"  
  --log-pipe="""  
  exited with code 1.  
MyGame.Windows	C:\Users\boris\.nuget\packages\xenko.core.assets.compilerapp\3.1.0.1-beta01-0430\build\Xenko.Core.Assets.CompilerApp.targets	68	

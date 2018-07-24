#load nuget:https://www.myget.org/F/cake-contrib/api/v2?package=Cake.Recipe&version=0.3.0-unstable0374

Environment.SetVariableNames();

BuildParameters.SetParameters(context: Context,
                            title: "Cake.ImageMagick",
                            buildSystem: BuildSystem,
                            sourceDirectoryPath: "./src",
                            repositoryOwner: "RLittlesII",
                            repositoryName: "Cake.ImageMagick",
                            appVeyorAccountName: "RLittlesII",
                            shouldRunInspectCode: false,
                            shouldRunDupFinder: false,
                            shouldRunDotNetCorePack: true,
                            shouldRunCodecov: false);

BuildParameters.PrintParameters(Context);

ToolSettings.SetToolSettings(context: Context,
                            dupFinderExcludePattern: new string[] { BuildParameters.RootDirectoryPath + "/src/Cake.ImageMagick.Tests/*.cs", BuildParameters.RootDirectoryPath + "/src/**/Cake.ImageMagick.AssemblyInfo.cs" },
                            testCoverageFilter: "+[*]* -[xunit.*]* -[Cake.Core]* -[Cake.Testing]* -[*.Tests]* -[FakeItEasy]*",
                            testCoverageExcludeByAttribute: "*.ExcludeFromCodeCoverage*",
                            testCoverageExcludeByFile: "*/*Designer.cs;*/*.g.cs;*/*.g.i.cs");

Build.RunDotNetCore();
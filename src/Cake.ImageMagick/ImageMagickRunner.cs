using System.Collections.Generic;
using Cake.Core;
using Cake.Core.IO;
using Cake.Core.Tooling;

namespace Cake.ImageMagick
{
    public class ImageMagickRunner : Tool<ImageMagickOptions>
    {
        public ImageMagickRunner(IFileSystem fileSystem,
            ICakeEnvironment environment,
            IProcessRunner processRunner,
            IToolLocator tools) : base(fileSystem, environment, processRunner, tools)
        {
        }

        public void Magick(ImageMagickOptions options)
        {
            Run(options, Arguments(options));
        }

        private ProcessArgumentBuilder Arguments(ImageMagickOptions options)
        {
            var builder = new ProcessArgumentBuilder();
            return builder;
        }

        protected override string GetToolName() => "magick";

        protected override IEnumerable<string> GetToolExecutableNames() => new[] {"magick", "magick.exe"};
    }
}
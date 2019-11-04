using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8
{
    /// <summary>
    /// Default interface methods - define an interface with default implementations!
    /// Note that accessibility modifiers are now possible in interfaces, too.
    /// </summary>
    public interface IDeveloper
    {
        public string FrontendLanguage => "JavaScript";
        public string BackendLanguage => "C#";

        public string DeveloperIdentityMessage =>
            $"I do {FrontendLanguage} on the frontend and {BackendLanguage} on the backend";

        public void SayIdentity() => Console.WriteLine(DeveloperIdentityMessage);
    }

    /// <summary>
    /// General developer. Doesn't provide any implementation of the interface!
    /// </summary>
    public class AverageDotNetDeveloper : IDeveloper
    {
    }

    public class FSharpDeveloper : IDeveloper
    {
        public string BackendLanguage => "F#";
        public string FrontendLanguage => "F# via Fable";
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
namespace ImagePluginFramework;

public interface IPlugin
{
    string Name { get; }
    void Initialize();
    void ApplyEffect(Image image);    
}

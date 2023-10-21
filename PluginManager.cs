using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ImagePluginFramework;

public class PluginManager
{
    private List<IPlugin> plugins;

    /// <summary>
    /// Initializes a new instance of the PluginManager class.
    /// </summary>
    public PluginManager()
    {
        plugins = new List<IPlugin>();
    }

    /// <summary>
    /// Adds the specified plugin to the list of plugins.
    /// </summary>
    /// <param name="plugin">The plugin to be added.</param>
    public void AddPlugin(IPlugin plugin)
    {
        plugins.Add(plugin);
    }

    /// <summary>
    /// Removes the specified plugin from the list of plugins.
    /// </summary>
    /// <param name="plugin">The plugin to be removed.</param>
    public void RemovePlugin(IPlugin plugin)
    {
        plugins.Remove(plugin);
    }

    /// <summary>
    /// Returns an enumerable collection of plugins.
    /// </summary>
    /// <returns>An enumerable collection of plugins.</returns>
    public IEnumerable<IPlugin> GetPlugins()
    {
        return plugins.AsReadOnly();
    }

    /// <summary>
    /// Applies effects to a list of images using plugins.
    /// </summary>
    /// <param name="images">The list of images to apply effects to.</param>
    public void ApplyEffectsToImages(List<Image> images)
    {
        foreach (Image image in images)
        {
            foreach (Effect effect in image.Effects)
            {
                foreach (IPlugin plugin in plugins)
                {
                    if (plugin.Name == effect.Name)
                    {
                        plugin.ApplyEffect(image);
                        break;
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagePluginFramework;

public class ImageProcessor
{
    private List<Image> images;
    private PluginManager pluginManager = new PluginManager();

    /// <summary>
    /// Initializes a new instance of the ImageProcessor class.
    /// </summary>
    public ImageProcessor()
    {
        images = new List<Image>();
    }

    /// <summary>
    /// Adds the specified image to the collection of images.
    /// </summary>
    /// <param name="image">The image to be added.</param>
    public void AddImage(Image image)
    {
        images.Add(image);
    }

    /// <summary>
    /// Removes the specified image from the collection of images.
    /// </summary>
    /// <param name="image">The image to be removed.</param>
    public void RemoveImage(Image image)
    {
        images.Remove(image);
    }

    /// <summary>
    /// Applies effects to a collection of images using the provided plugin manager.
    /// </summary>
    /// <param name="pluginManager">The plugin manager responsible for loading and managing plugins.</param>
    public void ProcessImages(PluginManager pluginManager)
    {
        foreach (Image image in images)
        {
            foreach (IPlugin plugin in pluginManager.GetPlugins())
            {
                plugin.ApplyEffect(image);
            }
        }
    }

    /// <summary>
    /// Returns a list of processed images.
    /// </summary>
    /// <returns>A list of processed images.</returns>
    public List<Image> GetProcessedImages()
    {
        return images.ToList();
    }

    /// <summary>
    /// Clears the collection of images.
    /// </summary>
    public void ClearImages()
    {
        images.Clear();
    }

    /// <summary>
    /// Adds the specified plugin to the plugin manager.
    /// </summary>
    /// <param name="plugin">The plugin to be added to the plugin manager.</param>
    public void AddEffectToManager(IPlugin plugin)
    {
        pluginManager.AddPlugin(plugin);
    }

    /// <summary>
    /// Removes the specified plugin from the plugin manager.
    /// </summary>
    /// <param name="plugin">The plugin to be removed from the plugin manager.</param>
    public void RemoveEffectFromManager(IPlugin plugin)
    {
        pluginManager.RemovePlugin(plugin);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagePluginFramework;

public class Image
{
    public string Path { get; }
    public int Width { get; }
    public int Height { get; }
    public List<Effect> Effects { get; }

    /// <summary>
    /// Initializes a new instance of the Image class with an empty list of effects.
    /// </summary>
    public Image()
    {
        Effects = new List<Effect>();
    }

    /// <summary>
    /// Initializes a new instance of the Image class with the specified path, width, and height.
    /// </summary>
    /// <param name="path">The path of the image.</param>
    /// <param name="width">The width of the image.</param>
    /// <param name="height">The height of the image.</param>
    public Image(string path, int width, int height)
    {
        Path = path;
        Width = width;
        Height = height;
        Effects = new List<Effect>();
    }

    /// <summary>
    /// Adds an effect to the image with the specified effect name and parameters.
    /// </summary>
    /// <param name="effectName">The name of the effect.</param>
    /// <param name="parameters">The dictionary of parameters associated with the effect.</param>
    public void AddEffect(string effectName, Dictionary<string, object> parameters)
    {
        Effects.Add(new Effect(effectName, parameters));
    }

    /// <summary>
    /// Adds the specified effect to the image.
    /// </summary>
    /// <param name="effect">The effect to add.</param>
    public void AddEffect(Effect effect)
    {
        Effects.Add(effect);
    }

    /// <summary>
    /// Removes the specified effect from the image.
    /// </summary>
    /// <param name="effect">The effect to remove.</param>
    public void RemoveEffect(Effect effect)
    {
        Effects.Remove(effect);
    }

    /// <summary>
    /// Retrieves the effect with the specified effect name.
    /// </summary>
    /// <param name="effectName">The name of the effect to retrieve.</param>
    /// <returns>The effect with the specified name, or null if not found.</returns>
    public Effect GetEffect(string effectName)
    {
        return Effects.FirstOrDefault(e => e.Name == effectName);
    }

    /// <summary>
    /// Removes the effect with the specified effect name from the image.
    /// </summary>
    /// <param name="effectName">The name of the effect to remove.</param>
    public void RemoveEffect(string effectName)
    {
        Effect effect = Effects.FirstOrDefault(e => e.Name == effectName);
        if (effect != null)
        {
            Effects.Remove(effect);
        }
    }
}

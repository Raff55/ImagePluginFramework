using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagePluginFramework;

public class Effect
{
    public string Name { get; }
    public Dictionary<string, object> Parameters { get; }

    /// <summary>
    /// Initializes a new instance of the Effect class with the specified name and parameters.
    /// </summary>
    /// <param name="name">The name of the effect.</param>
    /// <param name="parameters">The dictionary of parameters associated with the effect.</param>
    public Effect(string name, Dictionary<string, object> parameters)
    {
        Name = name;
        Parameters = parameters;
    }

    /// <summary>
    /// Modifies the value of a parameter by its name.
    /// </summary>
    /// <param name="parameterName">The name of the parameter to modify.</param>
    /// <param name="value">The new value for the parameter.</param>
    public void ModifyParameter(string parameterName, object value)
    {
        Parameters[parameterName] = value;
    }

    /// <summary>
    /// Retrieves the value of a parameter by its name.
    /// </summary>
    /// <param name="parameterName">The name of the parameter to retrieve.</param>
    /// <returns>The value of the parameter, or null if the parameter does not exist.</returns>
    public object GetParameter(string parameterName)
    {
        return Parameters.ContainsKey(parameterName) ? Parameters[parameterName] : null;
    }

    /// <summary>
    /// Sets the value of a parameter by its name.
    /// </summary>
    /// <param name="parameterName">The name of the parameter to set.</param>
    /// <param name="value">The new value for the parameter.</param>
    public void SetParameter(string parameterName, object value)
    {
        Parameters[parameterName] = value;
    }
}

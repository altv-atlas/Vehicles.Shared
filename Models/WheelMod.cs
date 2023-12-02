namespace AltV.Atlas.Vehicles.Shared.Models;

/// <summary>
/// Object that stores wheel modification data
/// </summary>
public record WheelMod
{
    /// <summary>
    /// The vehicle wheel index
    /// </summary>
    public byte Index { get; set; }
    
    /// <summary>
    /// The wheels camber value
    /// </summary>
    public float Camber { get; set; }
    
    /// <summary>
    /// The wheels height value
    /// </summary>
    public float Height { get; set; }

    /// <summary>
    /// The wheels rimRadius value
    /// </summary>
    public float RimRadius { get; set; }

    /// <summary>
    /// The wheels trackWidth value
    /// </summary>
    public float TrackWidth { get; set; }

    /// <summary>
    /// The wheels tyreRadius value
    /// </summary>
    public float TyreRadius { get; set; }

    /// <summary>
    /// The wheels tyreWidth
    /// </summary>
    public float TyreWidth { get; set; }
}
namespace AltV.Atlas.Vehicles.Shared.Models;

/// <summary>
/// Object that stores wheel modification data
/// </summary>
public class WheelMod
{
    public byte Index { get; set; }

    public float Camber { get; set; }

    public float Height { get; set; }
    
    public float RimRadius { get; set; }
    
    public float TrackWidth { get; set; }
    
    public float TyreRadius { get; set; }
    
    public float TyreWidth { get; set; }

}
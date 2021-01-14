using Godot;
using System;

public class Main : Node2D
{
    public override void _Ready()
    {
        AudioStreamPlayer midiPlayer = (AudioStreamPlayer)GD.Load<GDScript>("res://addons/midi/MidiPlayer.gd").New("GodotMidiPlayer");
        AddChild(midiPlayer);
        midiPlayer.Call("set_file", new object[] { "Music-133.mid" });
        midiPlayer.Play();
    }
}

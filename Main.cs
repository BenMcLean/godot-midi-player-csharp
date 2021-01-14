using Godot;
using System;

public class Main : Node2D
{
    public override void _Ready()
    {
        Node midiPlayer = (Node)GD.Load<GDScript>("res://addons/midi/MidiPlayer.gd").New();
        AddChild(midiPlayer);
        midiPlayer.Set("file", "Music-133.mid");
        midiPlayer.Set("soundfont", "Aspirin-Stereo.sf2");
        midiPlayer.Call("play", 0f);
    }
}

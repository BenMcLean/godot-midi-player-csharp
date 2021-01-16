using Godot;
using System;

public class Main : Node2D
{
    public override void _Ready()
    {
        Node midiPlayer = (Node)GD.Load<GDScript>("res://addons/midi/MidiPlayer.gd").New();
        AddChild(midiPlayer);
        midiPlayer.Set("soundfont", "res://1mgm.sf2");
        //midiPlayer.Set("file", "Music-133.mid");
        Godot.Object smf = (Godot.Object)GD.Load<GDScript>("res://addons/midi/SMF.gd").New();
        smf.Call("read_data", System.IO.File.ReadAllBytes("Music-133.mid"));
        midiPlayer.Set("smf_data", smf);
        midiPlayer.Call("play", 0f);
    }
}

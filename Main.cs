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
        Reference smf = (Reference)GD.Load<GDScript>("res://addons/midi/SMF.gd").New();
        midiPlayer.Set("smf_data", smf.Call("read_data", System.IO.File.ReadAllBytes("Music-133.mid")));
        if (midiPlayer.Get("smf_data") == null)
            GD.Print("it's null");
        midiPlayer.Set("loop", true);
        midiPlayer.Call("play", 0f);
    }
}

using Godot;
using System;

public class Main : Node2D
{
    public override void _Ready()
    {
        Node midiPlayer = GD.Load<PackedScene>("res://addons/midi/MidiPlayer.tscn").Instance();
        AddChild(midiPlayer);
    }
}

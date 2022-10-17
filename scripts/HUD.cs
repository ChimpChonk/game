using Godot;
using System;

public class HUD : CanvasLayer
{
    //Coin counter on hud 
    public override void _Ready()
    {   
        var label = GetNode<Label>("Coins");
        label.SetText("3");
    }
}

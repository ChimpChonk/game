using Godot;
using System;

public class coin : Area2D
{
    AnimationPlayer animationPlayer;
    int coins = 0;
    public override void _Ready()
    {
        coins = 0;
        animationPlayer = (AnimationPlayer)GetNode("AnimationPlayer");
    }
    public void _on_coin_body_entered(Node body)
    {
        coins = coins + 1;
        animationPlayer.Play("coin_bounce");
        
    }

    private void _on_AnimationPlayer_animation_finished(AnimationPlayer animation)
    {
        GD.Print(coins); 
        QueueFree();
    }

    
}

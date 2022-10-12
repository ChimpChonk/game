using Godot;
using System;

public class coin : Area2D
{
    AnimationPlayer animationPlayer;
    public override void _Ready()
    {
        animationPlayer = (AnimationPlayer)GetNode("AnimationPlayer");
    }
    private void _on_coin_body_entered(Node Body)
    {
        
        animationPlayer.Play("coin_bounce");
    }

    private void _on_AnimationPlayer_animation_finished(AnimationPlayer animation)
    {
        QueueFree();
    }
}

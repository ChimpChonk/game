using Godot;
using System;

public class coin : Area2D
{

    Player player = new Player();
    AnimationPlayer animationPlayer;

    public override void _Ready()
    {
        animationPlayer = (AnimationPlayer)GetNode("AnimationPlayer");
    }
    public void _on_coin_body_entered(Node body)
    {
        animationPlayer.Play("coin_bounce");
        player.Add_coin();
    }

    private void _on_AnimationPlayer_animation_finished(AnimationPlayer animation)
    {
        QueueFree();
    }

    
}

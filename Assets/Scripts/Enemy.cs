using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	[System.Serializable]
	public class EnemyStats {
		public int health = 10;
	}
	public EnemyStats enemyStats = new EnemyStats ();

	public void DamageEnemy (int damage)
	{
		enemyStats.health -= damage;
		if(enemyStats.health <= 0){
			//GameManager.KillEnemy (this);
		}
	}
}

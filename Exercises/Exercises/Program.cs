//Coding Exercises for C# Part 3.0 - DRY Principle
//Exercise_1
using System.Diagnostics;
using System.Numerics;
using System.Threading.Tasks.Dataflow;
using System.Timers;

public Text goldText;
public Text crystalText;
public Text foodText;

void UpdateResource(goldText 50)
{
    resourceText.text = "Amount: " + amount.ToString();
}

//Exercise_2
void PlaySound(AudioClip clipToPlay)
{
    AudioSource audio = GetComponent<AudioSource>();
    audio.clip = clipToPlay;
    audio.Play();
}
void Jump()
{
    PlaySound(jumpSound); 
    rb.velocity = Vector2.up * jumpForce;
}

void Shoot()
{
    PlaySound(shootSound); 
    Instantiate(bullet); 
}

//Exercise_3
void TakeDamage(int amount) {
        health -= amount;
    if (health < 0) health = 0;
    Debug.Log("Health: " + health);

}

//Exercise_4
void SpawnMob(mobName amount)
{
    Vector3 spawnPos = TransformBlock.position + new Vector3(0, 1, 0);
    PlaySpawnParticle(spawnPos);
}
void SpawnGoblin()
{
    Instantiate(goblinPrefab, spawnPos, Quaternion.identity);
}
void SpawnOrc()
{
    Instantiate(orcPrefab, spawnPos, Quaternion.identity);
}

//Exercise_5
//What if the map size increases?
float mapBoundary = 100f;
void MoveRight()
{
    if (transform.position.x < mapBoundary)
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}
void MoveLeft()
{
    if (transform.position.x > -mapBoundary)
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}


//Coding Exercises for C# Part 3.1 - YAGNI Principle
//Exercise_1
public class HealthPotion
{
    public int healAmount = 10;
    public void Consume(Player player)
    {
        player.Heal(healAmount);

    }
}

//Exercise_2
public class CollectibleDot
{
    public int pointValue = 10;
    public void Collect(Player player)
    {
        player.AddScore(pointValue);
    }
}

//Exercise_3
public class Spaceship
{
    public float moveSpeed = 5f;
    public void MoveHorizontal(float input)
    {
        transform.Translate(Vector3.right * input * moveSpeed * Time.deltaTime);
    }
}

//Exercise_4
public class PlayerStats
{
    public float jumpForce = 5f;
}

//Exercise_5
public interface IWeaponSystem
{
    void Fire();
}
public class Pistol : IWeaponSystem
{
    // Implements all 5 methods, even though 3 of them are empty
}


//Coding Exercises for C# Part 3.2 - KISS Principle
//Exercise_1
public bool IsPlayerDead()
{
    return health <= 0;
}

//Exercise_2
List{1, 2, 3} startingLevels = new List<int>();

//Exercise_3
void CheckEnemy(string enemyType)
{
    if (enemyType == "Goblin" || enemyType == "Orc" || enemyType == "Troll")
    {
        Attack();
    }
    else
    {
        RunAway();
    }
}

//Exercise_4
float timer = 5f;
void Update()
{
    if (isCooldown)
    {
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            isCooldown = false;
            timer = 5f;
        }
    }
}
//Exercise_5
int GetHighestScore(int score1, int score2)
{
    if (score1 > score2)
    {
        return score1;
    }
    else
    {
        return score2;
    }
}
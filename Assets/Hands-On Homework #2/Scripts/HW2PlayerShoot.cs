using UnityEngine;

public class HW2PlayerShoot : MonoBehaviour
{
    public GameObject preFab;
    public GameObject preFab2;
    public Transform bulletTrash;
    public Transform bulletSpawn;

    private const float _timer1 = 0.375f;
    private float _currentTime1 = 0.375f;
    private bool _canShoot1 = true;

    private const float _timer2 = 1.125f;
    private float _currentTime2 = 1.125f;
    private bool _canShoot2 = true;

    private void Update()
    {
        TimerCalculate();
        LeftClickShoot();
        RightClickShoot();
    }
    
    //Runs the timer
    private void TimerCalculate()
    {
        //Check when the player can't shoot bullet
        if (!_canShoot1)
        {
            //Start the timer
            _currentTime1 -= Time.deltaTime;

            //Check once the timer is less than 0
            if (_currentTime1 < 0)
            {
                //Player can shoot bullet1 again and timer is reset and ready
                _canShoot1 = true;
                _currentTime1 = _timer1;
            }
        }
        //Check when the player can't shoot bullet2
        if (!_canShoot2)
        {
            //Start the timer
            _currentTime2 -= Time.deltaTime;

            //Check once the timer is less than 0
            if (_currentTime2 < 0)
            {
                //Player can shoot bullet2 again and timer is reset and ready
                _canShoot2 = true;
                _currentTime2 = _timer2;
            }
        }
    }

    private void LeftClickShoot()
    {
        //Check if the player inputted the left mouse button and the player can shoot
        if (Input.GetKeyDown(KeyCode.Mouse0) && _canShoot1)
        {
            //Spawn the bullet
            GameObject Bullet = Instantiate(preFab, bulletSpawn.position, Quaternion.identity);

            //Despawn the bullet (I think)
            Bullet.transform.SetParent(bulletTrash);

            //Prevents bullet spam
            _canShoot1 = false;

        }
    }

    private void RightClickShoot()
    {
        //Check if the player inputted the right mouse button and the player can shoot
        if (Input.GetKeyDown(KeyCode.Mouse1) && _canShoot2)
        {
            //Spawn the bullet
            GameObject Bullet2 = Instantiate(preFab2, bulletSpawn.position, Quaternion.identity);

            //Despawn the bullet
            Bullet2.transform.SetParent(bulletTrash);

            //Prevents bullet2 spawm
            _canShoot2 = false;
        }
    }
}

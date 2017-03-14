# Unity_Move_Learn_1
最一般的移動方式，使用transform.Translate 與 rigidboddy.velocity 移動，
對2D物件移動是最佳的；但在3D物件移動中，還不是最好的移動方式！

使用Translate 跟直接修改 Position 相似，「強制移動」到某個位置！所以撞到牆壁時會有彈回的感覺，被牆壁排斥出去！
但使用 rigidboddy 的 velocity 就不是強制移動到某個地點，而是用「推的」，給一個力道讓物件移動。不會有被牆壁排斥出去的感覺！


Game Screenshot
================
<img src="https://github.com/Yan-Jun/Unity_Move_Learn_1/blob/master/move.jpg">


兩種移動方式撞到牆壁的狀況
================
<img src="https://github.com/Yan-Jun/Unity_Move_Learn_1/blob/master/througe.jpg" height="400" width="300">  <img src="https://github.com/Yan-Jun/Unity_Move_Learn_1/blob/master/return.jpg" height="400" width="300">


玩家腳本控制移動模式
================
<img src="https://github.com/Yan-Jun/Unity_Move_Learn_1/blob/master/controller.jpg" width="300">



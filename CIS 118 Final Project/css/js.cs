.img-gallery{
				width: 80%;
				margin: 50px auto 50px;
				display: grid;
				grid-template-columns: repeat(auto-fit, minmax(250px, 1fr));
				grid-gap: 30px;
			}
			.img-gallery img{
				width: 100%;
				cursor: pointer;
			}
			.img-gallery img:hover{	
				transform: scale(0.8) rotate(-15deg);
				border-radius: 20px;
				box-shadow: 0 32px 75px rgba(68,77,136,0.2);
			}
			.full-img{
				width: 100%;
				height: 100vh;
				background: rgba(0,0,0,0.9);
				position: fixed;
				top: 0;
				left:0;
				display: none;
				align-items: center;
				justify-content: center;
				z-index: 100;
			}
			.full-img img{
				width: 90%;
				max-width: 500px;
			}
			.full-img span{
				position: absolute;
				top: 5%;
				right: 5%;
				font-size: 30px;
				color:#fff;
				cursor: pointer;

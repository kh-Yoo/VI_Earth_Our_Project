# VI_Earth_Our_Project
## 7주차

[실행 영상](https://youtu.be/-VA0qKtAGOA)
![일과표1](https://user-images.githubusercontent.com/62977669/96365322-c2fd6200-117a-11eb-82fb-903ba079ea8a.JPG)
![일과표2](https://user-images.githubusercontent.com/62977669/96365324-c42e8f00-117a-11eb-8369-ea62b2fcfa2b.JPG)

1. 일과표
기존의 플레이어가 오브젝트를 먹으면 인벤토리에 아이템이 추가되는것을
프로젝트 구성에 맞게 해당 오브젝트의 미션을 완료하여 일과표에 미션목록들이 줄어드는 효과로 변경하였습니다.
프로젝트 화면에는 2가지의 오브젝트가 가지는 미션 목록만 보여지고 있지만 이후 오브젝트와 해당 미션을 추가할 예정입니다.
일과표는 우선 흰색글로 미션 수행이 가능한 오브젝트의 위치, 미션 내용, 플레이어가 수행해야할 미션 갯수가 출력이 되어있습니다.
플레이어가 미션 하나를 클리어하면 노란색 글씨로 변하며, 미션을 모두 완료하면 초록색 글씨로 변합니다.
또한 사용자의 편의에 맞게 일과표를 보고싶지 않은경우 클릭해서 감추는 기능을 만들었습니다.

![상호1](https://user-images.githubusercontent.com/62977669/96365327-c4c72580-117a-11eb-91bf-dc289646b85d.JPG)
![상호2](https://user-images.githubusercontent.com/62977669/96365328-c55fbc00-117a-11eb-849d-603b38f6fe28.JPG)

2. 플레이어와 미션오브젝트의 상호작용
우선 플레이어가 미션 오브젝트를 기존의 배경(타일)과 헷갈리지 않도록 구성하기 위해 거리가 먼경우에는 변화가 없지만
일정거리에 닿을 경우 오브젝트 태두리에 노란색 컬러를 입히고, 오브젝트와 가까운 거리일 경우에는 오브젝트의 색깔을 노란빛으로 만들었습니다.
기존의 오브젝트의 역할이 소모품이었던 것을 우측하단의 버튼을 누르면 미니게임을 플레이하고 성공을 하면 미션이 완료되는 형식으로 제작할 예정입니다.

![지도1](https://user-images.githubusercontent.com/62977669/96365325-c42e8f00-117a-11eb-9c05-5a648220c518.JPG)
![지도2](https://user-images.githubusercontent.com/62977669/96365326-c4c72580-117a-11eb-9ff0-458312a82d45.JPG)

3. 지도 Panel 업그레이드
기존에 만들던 지도 패널에는 지도 이미지만 뜨고 꺼지는 작동이였지만 지금은 지도를 실제 맵의 x축에서 1200 : 1,
y축에서는 900 : 1 비율로 나눠서 사용자의 위치가 지도 패널에 뜨고
실시간으로 지도 패널에 사용자의 위치에 따라 노란 점이 움직인다.
제작하는 게임에 맞는 지도 이미지가 완성이 되면 경계선을 조금 더 정확하게 해서 완성도를 높일 것입니다.

## 6주차

![1](https://user-images.githubusercontent.com/62977669/95690666-40454600-0c54-11eb-9c0b-89bb3262f5ab.JPG)
![2](https://user-images.githubusercontent.com/62977669/95690669-420f0980-0c54-11eb-8b60-4b4a3bfd9acc.JPG)
![3](https://user-images.githubusercontent.com/62977669/95690670-42a7a000-0c54-11eb-970d-a923d454d18c.JPG)

[실행 영상](https://youtu.be/xCcYH-45EbU)

-Panel을 이용한 미션 열기  
2개의 Button을 만들었습니다.  
일단 첫 번째 버튼은 캐릭터가 움직여도  
오른쪽 상단에 고정되고  
누르면 Panel이 보이면서 지도가 보이고 자신의 캐릭터 위치를  
표시해주는 역할을 하는 Map 버튼입니다.  
그리고 두 번째 버튼은 캐릭터가 미션을 하기 위해  
고정된 자리에서 캐릭터가 가까이 오면 클릭을 해서  
Panel이 보이면서 미션을 하도록 하는 Mission 버튼입니다.  
아직은 버튼들을 클릭 시 Panel이 뜨게 구현했고  
더 원활한 플레이를 하도록 구현중입니다.  

![1](https://user-images.githubusercontent.com/62977669/95690677-5521d980-0c54-11eb-9416-9af8f956e63e.PNG)
![2](https://user-images.githubusercontent.com/62977669/95690678-55ba7000-0c54-11eb-9dba-f9031edcd759.PNG)
![3](https://user-images.githubusercontent.com/62977669/95690679-56530680-0c54-11eb-8e0f-f842802c5de1.PNG)
![4](https://user-images.githubusercontent.com/62977669/95690680-56eb9d00-0c54-11eb-9180-fe0d5ae6f8ac.PNG)
![5](https://user-images.githubusercontent.com/62977669/95690681-56eb9d00-0c54-11eb-9ba3-a6e81ff7bbd7.PNG)

1. sign up 버튼을 클릭하여 회원가입 창을 생성
2. 생성된 회원가입 창의 공백이 있을 시 sign 버튼을 누를 수 없게 설정하고 cancel 버튼만 가능
   ID, Password, Email을 입력하고 sign 버튼 클릭
3. 입력한 정보 표시
4. 해당 정보가 서버로 전송됨.
5. 데이터베이스에 유저 회원가입 정보 저장

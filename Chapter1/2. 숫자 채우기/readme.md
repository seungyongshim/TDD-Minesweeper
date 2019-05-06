# 숫자 채우기

### 지뢰찾기 알고리즘
- TODO: 지뢰찾기 알고리즘 설명이 여기 있어야 함

### OOP 형태로 구조를 개선하기

- TDD(테스트 주도 개발)을 위하여 객체 지향 구조를 설계합니다.
- Class MineMap

![1557120149678](./Images/1.png)
- Class MineItem

![1557120247097](C:\Users\SYSHIM\Documents\TrainingMakeMinesweeper\Chapter1\2. 숫자 채우기\Images\2.png)

### Class MineItem
- bool IsBomb 속성 : 폭탄이면 true, 아니면 false
- int NearBombsCount 속성 : 주변 8칸에 폭탄 개수



### 폭탄 근처에 숫자를 채우기

- 
- 지뢰 10개를 빨간팬으로 ∗ 모양으로 그려 봅니다.
- 나머지 칸에 숫자를 채웁니다.

![1557107542231](./Images/1.png)

### 종이에 그린 지뢰판을 컴퓨터로 옮기기
- 다음과 같은 결과를 얻는 코드를 만들어 봅시다.

![1557119234418](./Images/2.png)

- 각 아이템(숫자, 폭탄)의 구분은 공백으로 합니다.

- MineSweeper.Tests를 통과 해야 합니다.
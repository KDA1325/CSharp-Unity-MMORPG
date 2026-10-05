# C# · Unity MMORPG 실습 기록

강의 실습은 `main`에 모으고, 실습을 마칠 때마다 커밋합니다.

## 폴더 구성

| 폴더 | 실습 내용 |
| --- | --- |
| `CSharpPractice/01_TextRPG` | Part 1 섹션 4: 디버깅 기초, 직업 고르기, 플레이어·몬스터 생성, 전투 |
| `CSharpPractice/02_OOP` | Part 1 섹션 5: 객체지향의 시작, 값과 참조, 스택과 힙, 생성자, static, 상속, 은닉성, 클래스 형식 변환, 다형성, 문자열 |
| `CSharpPractice/03_TextRPG2` | Part 1 섹션 6: 객체지향을 적용한 플레이어·몬스터 생성, 게임 진행, 마무리 |
| `CSharpPractice/04_DataStructures` | Part 1 섹션 7: 배열, 연습 문제, 다차원 배열, List, Dictionary |
| `CSharpPractice/05_LanguageFeatures` | Part 1 섹션 8: Generic, Interface, Property, Delegate, Event, Lambda, Exception, Reflection, Nullable |
| `UnityPractice` | Unity 프로젝트 |

## 실습 방식

- C# 실습을 시작할 때 `CSharpPractice`에 솔루션 하나를 만들고, 위 폴더마다 필요한 콘솔 프로젝트를 추가합니다.
- 강의 한 편마다 폴더나 프로젝트를 만들지 않고, 같은 섹션의 실습은 해당 폴더에서 진행합니다.
- TextRPG와 TextRPG2는 각각 별도 프로젝트로 진행하고, 플레이어 생성·전투 등 진행 단계는 커밋으로 남깁니다.
- 문법 실습을 파일로 나누면 실행 진입점은 하나만 두고 실습별 메서드를 호출합니다.
- Part 2의 Big-O, 선형 자료구조, 미로, 그래프, 트리, A* 실습 폴더는 해당 강의를 시작할 때 추가합니다.
- Unity 프로젝트는 `UnityPractice/<프로젝트명>`에 만듭니다.
- 폴더만 준비한 상태이며, 솔루션과 프로젝트는 아직 생성하지 않았습니다.

커밋 메시지는 `type: 한국어 제목` 형식을 사용하며 스코프와 끝 마침표를 넣지 않습니다.

예: `feat: TextRPG 전투 기능을 구현`, `docs: 상속과 다형성 실습 내용을 정리`, `chore: 실습 폴더 구조를 구성`.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuiestionList1 : MonoBehaviour
{
    lis[] li = new lis[]{
        new lis("���������������� ��������� ����� ��������� ��� ������� �������� ������ ��� �����", new List<string>{ "�������������", "q", "q", "q" }),
        new lis("����������� ������������� ������� ��������� ��� ���������������� ������, �������� ���� ��� ������� ������������ ������������", new List<string>{ "�������������", "q", "q", "q" }),
        new lis("������� �������� �� �������� ������������� ����, ���������� ������������� �������� ������ ��� ������ � ������������ ������", new List<string>{ "�������������", "q", "q", "q" }),
        new lis("������������� ����", new List<string>{ "�������������", "q", "q", "q" }),
        new lis("���������� �������������� ���������� (� ������������ ���������, ����������)", new List<string>{ "�������������", "q", "q", "q" }) 
    };  

    public lis SendQuestion()
    {
        return li[Random.Range(0, li.Length)];
    }
}
public class lis
{
    public string quest;
    public List<string> answers;

    public lis(string quest, List<string> answers)
    {
        this.quest = quest;
        this.answers = answers;
    }
}
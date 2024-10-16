using System.Collections.Generic;
using System;

@Entity
public class Room
{
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;

    private String roomName;
    private String creator;

    @ElementCollection
    private List<String> players = new ArrayList<>(); // Danh sách người chơi

    // Getters và setters
}

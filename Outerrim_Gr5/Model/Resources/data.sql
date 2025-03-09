-- Aircraft Specifications
INSERT INTO AIRCRAFT_SPECIFICATIONS (AIRCRAFT_SPECIFICATION_ID, STRUCTURE, FUEL_CAPACITY, MIN_SPEED, MAX_SPEED, MAX_ALTITUDE, SPECIFICATION_CODE)
VALUES
    (1, 3, 10, 2, 6, 5, 'Tunderbolt'),
    (2, 2, 8, 3, 8, 4, 'Vulture'),
    (3, 4, 12, 1, 7, 6, 'Raven');

-- Aircrafts
INSERT INTO AIRCRAFTS (AIRCRAFT_ID, ALTITUDE, FUEL, NAME, SPECIFICATION_ID, SPEED)
VALUES
    (1, 5, 6, 'Executioner', 1, 4),
    (2, 3, 3, 'Dakkajet', 2, 3),
    (3, 6, 9, 'Blackbird', 3, 5);

-- Mercenaries
INSERT INTO MERCENARIES (MERCENARY_ID, BODY_SKILL, COMBAT_SKILL, FIRST_NAME, LAST_NAME)
VALUES
    (1, 4, 4, 'Han', 'Solo'),
    (2, 8, 8, 'Luke', 'Skywalker'),
    (3, 6, 7, 'Boba', 'Fett'),
    (4, 3, 5, 'Jango', 'Fett'),
    (5, 9, 9, 'Darth', 'Vader');

-- Compartments
INSERT INTO COMPARTMENTS (COMPARTMENT_ID, AIRCRAFT_ID, NAME)
VALUES
    (1, 1, 'Pilot Cockpit'),
    (2, 1, 'Storage Compartment'),
    (3, 1, 'Machine Room'),
    (4, 1, 'Weapon Compartment Rear'),
    (5, 2, 'Pilot Cockpit'),
    (6, 2, 'Weapon Bay'),
    (7, 3, 'Navigation Deck');

-- Crew Assignments (Aircraft - Mercenary relationships)
INSERT INTO AIRCRAFT_CREW_JT (AIRCRAFT_ID, MERCENARY_ID)
VALUES
    (1, 1), -- Han Solo in Executioner
    (1, 2), -- Luke Skywalker in Executioner
    (2, 3), -- Boba Fett in Dakkajet
    (2, 4), -- Jango Fett in Dakkajet
    (3, 5); -- Darth Vader in Blackbird

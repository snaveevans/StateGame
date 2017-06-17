using System;
using System.Linq;
using System.Collections.Generic;
using ConsoleApp.Entities;
using static System.Console;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game();
            var terminalState = new State();
            var units = new List<Unit>();
            units.AddRange(new[] { new Unit(), new Unit(), new Unit(), new Unit() });
            terminalState.Units = units;
            game.States.Add(terminalState);
            game.States.Add(new State());
            game.States.Add(new State());
            game.States.Add(new State());

            while (game.States.Any(state => state.Units.Count > 1))
            {
                var statesWithUnits = game.States
                    .Where(state => state.Units.Any())
                    .OrderByDescending(state => state.Units.Count)
                    .ToList();
                var designation = new Designation();
                game.Designations.Add(designation);
                var availableStates = game.States.Clone();

                foreach (var currentState in statesWithUnits)
                {
                    var separatingUnit = currentState.Units.First();
                    var otherUnits = currentState.Units
                        .Where(unit => unit != separatingUnit)
                        .ToList();

                    var hasCurrentState = availableStates.Remove(currentState);

                    var randomlySelectedState = RandomlySelectState(availableStates);
                    availableStates.Remove(randomlySelectedState);

                    var path = new Path(designation)
                    {
                        Origin = randomlySelectedState,
                        Destination = currentState
                    };
                    designation.Paths.Add(path);

                    currentState.Units.Remove(separatingUnit);
                    randomlySelectedState.Units.Add(separatingUnit);

                    randomlySelectedState = RandomlySelectState(availableStates);
                    availableStates.Remove(randomlySelectedState);
                    
                    path = new Path(designation)
                    {
                        Origin = randomlySelectedState,
                        Destination = currentState
                    };
                    designation.Paths.Add(path);

                    currentState.Units = currentState.Units.RemoveRange(otherUnits);
                    randomlySelectedState.Units.AddRange(otherUnits);

                    if (hasCurrentState)
                        availableStates.Add(currentState);
                }

                foreach (var currentState in availableStates)
                {
                    var tempStates = game.States.Clone();
                    tempStates.Remove(currentState);

                    var randomlySelectedState = RandomlySelectState(tempStates);

                    var path = new Path(designation)
                    {
                        Origin = randomlySelectedState,
                        Destination = currentState
                    };
                    designation.Paths.Add(path);
                }
            }
        }

        private static State RandomlySelectState(List<State> availableStates)
        {
            var stateMax = availableStates.Count -1;
            Random random = new Random();
            int statePosition = random.Next(0, stateMax);
            return availableStates[statePosition];
        }
    }
}

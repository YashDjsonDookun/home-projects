class Surgeon {
    constructor(name, department) {
      this.name = name;
      this.department = department;
    }
  }

/* These are instances of the class Surgeon */
const surgeonCurry = new Surgeon('Curry', 'Cardiovascular');
const surgeonDurant = new Surgeon('Durant', 'Orthopedics');

console.log(surgeonDurant.name);  // This will output the name of Surgeon Durant from the Orthopedics Department